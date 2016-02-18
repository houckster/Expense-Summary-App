using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Expense_Summary_App
{
    public partial class frmMain : Form
    {
        //Instantiate a new instance of frmMain and intialize
        public frmMain()
        {
            InitializeComponent();
        }

        public frmAddItem frmAddItem;

        private void frmMain_Load(object sender, EventArgs e)
        {
            //This line of code loads data into the 'dat_ExpenseItems.tbl_ExpenseItems' table. 
            try
            {
                this.tbl_ExpenseItemsTableAdapter.Fill(this.dat_ExpenseItems.tbl_ExpenseItems);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error # " + ex.Number + ": " + ex.Message, ex.GetType().ToString());
            }
        }


        #region Buttons

        //Add Item button code, pops a new instance of AddItem form 
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //used "using" to ensure better consumption of system resources
            using (var frmAddItem = new frmAddItem(this))
            {
                frmAddItem.ShowDialog();
            }
        }

        #endregion

        #region Methods

        /*Method to call from frmAddItem to pass the values from the ExpenseItem object created 
        with the textbox input and send to the data grid view*/
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public void SendToGrid(ExpenseItem expenseItem)
        {
            DateTime? date = System.Convert.ToDateTime(expenseItem.date);
            decimal miles = System.Convert.ToDecimal(expenseItem.miles);
            decimal rate = System.Convert.ToDecimal(expenseItem.rate);
            decimal mileageDollars = System.Convert.ToDecimal(expenseItem.mileageTotal);

            //create the new row
            DataRow newRow = dat_ExpenseItems.tbl_ExpenseItems.NewRow();
            newRow["first_name"] = txtFirstName.Text;
            newRow["last_name"] = txtLastName.Text;
            newRow["vendor_code"] = txtVendorCode.Text;
            newRow["start_date"] = dateTimePicker1.Value;
            newRow["end_date"] = dateTimePicker2.Value;
            newRow["receipt_date"] = date;
            newRow["description"] = expenseItem.description;
            newRow["expense_code"] = expenseItem.expenseCode;
            newRow["number_miles"] = miles;
            newRow["rate"] = rate;
            newRow["mileage_dollars"] = expenseItem.mileageTotal;
            newRow["total_expense"] = expenseItem.totalExpense;
            newRow["receipt_image"] = imageToByteArray(expenseItem.receiptImage);
            newRow["is_exported"] = "No";
            
            //add the row to the table
            this.dat_ExpenseItems.tbl_ExpenseItems.Rows.Add(newRow);

            //Save the row to the database
            this.tbl_ExpenseItemsTableAdapter.Update(this.dat_ExpenseItems.tbl_ExpenseItems);
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //includes generic SQL and ADO.NET exception handling
            try
            {
                this.Validate();
                this.tblExpenseItemsBindingSource.EndEdit();
                this.tbl_ExpenseItemsTableAdapter.Update(dat_ExpenseItems);
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("A concurrency error occured. " + "Some rows were not updated.", "Concurrecnt Exception");
                this.tbl_ExpenseItemsTableAdapter.Fill(this.dat_ExpenseItems.tbl_ExpenseItems);
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                tblExpenseItemsBindingSource.CancelEdit();
            }   
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error # " + ex.Number + ": " + ex.Message, ex.GetType().ToString());
            }
        }

        #endregion

        #region DataGridView Buttons
        
        //click event on datagridview
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //Edit button
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                //TODO - when clicked, using the data grid view data, send the values to a new frmAddItem
                //used "using" to ensure better consumption of system resources
                using (var frmAddItem = new frmAddItem(this))
                {
                    frmAddItem.ShowDialog();
                    //how do I get the datagrid values from the row into frmAddItem and then return them to same row?
                    //Do I need a new method to pass the row to an expense object on frmMain, then pass to frmAddItem inputs?
                    //ExpenseItemsDB.GetExpenseItem(System.Convert.ToInt32(this.idDataGridViewTextBoxColumn.ToString()));
                    frmAddItem.SendDataToForm2(ExpenseItemsDB.GetExpenseItem(System.Convert.ToInt32(this.idDataGridViewTextBoxColumn.ToString())));
                    

                    this.tblExpenseItemsBindingSource.EndEdit();
                    this.tbl_ExpenseItemsTableAdapter.Update(dat_ExpenseItems);
                }
            }

            //Delete button
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "By clicking yes, this expense item will be permanently removed from your record. Are you sure that you want to delete this?";
                string caption = "Permanent Delete Warning";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);

                //if yes is clicked, proceed with deletion
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    int rowIndex = e.RowIndex;
                    dataGridView1.Rows.RemoveAt(rowIndex);
                    dat_ExpenseItems.tbl_ExpenseItems.Rows[rowIndex].Delete();
                    tbl_ExpenseItemsTableAdapter.Update(dat_ExpenseItems);//****data reappearing when app loaded again.
                    this.tblExpenseItemsBindingSource.EndEdit();
                }
            }
        }
    }
}

        #endregion

