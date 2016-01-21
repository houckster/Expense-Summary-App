using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Summary_App
{
    public partial class frmMain : Form
    {
        //Instantiate a new instance of frmMain and intialize
        public frmMain()
        {
            InitializeComponent();
            ImportFile();
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

        //Edit button on datagridview
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //TODO - when clicked, using the data grid view data, send the values to a new frmAddItem

                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[e.RowIndex].Index);
            }
        }

        #endregion

        #region Methods

        //Method to call from frmAddItem to pass the values from the ExpenseItem object created 
        //with the textbox input and send to the data grid view
        public void SendToGrid(ExpenseItem expenseItem)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = expenseItem.date;
            row.Cells[1].Value = expenseItem.description;
            row.Cells[2].Value = expenseItem.expenseCode;
            row.Cells[3].Value = expenseItem.miles;
            row.Cells[4].Value = expenseItem.rate;
            row.Cells[5].Value = expenseItem.mileageTotal;
            row.Cells[6].Value = expenseItem.totalExpense;
            dataGridView1.Rows.Add(row);
        }

        //method to import the CSV file that has expense summary data
        private bool ImportFile()
        {
            // Displays an OpenFileDialog so the user can select a Cursor.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "CSV File|*.csv";
            openFileDialog1.Title = "Select a CSV file";
            openFileDialog1.ShowDialog();

            try
            {

                String fName;
                String textLine = string.Empty;
                String[] splitLine;

                // clear the grid view

                dataGridView1.Rows.Clear();

                fName = openFileDialog1.FileName;

                if (System.IO.File.Exists(fName))
                {
                    System.IO.StreamReader objReader = new System.IO.StreamReader(fName);

                    do
                    {
                        textLine = objReader.ReadLine();
                        if (textLine != "")
                        {
                            splitLine = textLine.Split(',');
                            if (splitLine[0] != "" || splitLine[1] != "")
                            {
                                dataGridView1.Rows.Add(splitLine);
                            }
                        }
                    } while (objReader.Peek() != -1);
                }
                return true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The process cannot access the file"))
                {
                    MessageBox.Show("The file you are importing is already open.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }

                return false;
            }
        }

         private void btnSave_Click(object sender, EventArgs e)
            {
                //TODO: code to save datagridview to same CSV used to populate the data
            }

        }
        
        #endregion
            
    }

