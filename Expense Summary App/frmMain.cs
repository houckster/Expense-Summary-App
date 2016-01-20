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

                //dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
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
        
        #endregion

    }
}
