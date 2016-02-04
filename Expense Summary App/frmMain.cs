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

namespace Expense_Summary_App
{
    public partial class frmMain : Form
    {
        //Instantiate a new instance of frmMain and intialize
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dat_ExpenseItems.tbl_ExpenseItems' table. You can move, or remove it, as needed.
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
        public void SendToGrid(ExpenseItem expenseItem)
        {
            /*DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = expenseItem.date;
            row.Cells[1].Value = expenseItem.description;
            row.Cells[2].Value = expenseItem.expenseCode;
            row.Cells[3].Value = expenseItem.miles;
            row.Cells[4].Value = expenseItem.rate;
            row.Cells[5].Value = expenseItem.mileageTotal;
            row.Cells[6].Value = expenseItem.totalExpense;
            row.Cells[7].Value = expenseItem.receiptImage;
            dataGridView1.Rows.Add(row);*/

            DataRow newRow = dat_ExpenseItems.tbl_ExpenseItems.NewRow();
            newRow["receipt_date"] = expenseItem.date;
            this.tblExpenseItemsBindingSource.EndEdit();
            this.tbl_ExpenseItemsTableAdapter.Update(dat_ExpenseItems);
            
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
                    ExpenseItemsDB.GetExpenseItem(System.Convert.ToInt32(dataGridView1.Columns[0]));
                    
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

