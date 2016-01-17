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
        public frmMain()
        {
            InitializeComponent();
        }

        
        //instantiate the Add Expense form to be show when the add item button is clicked
        //frmAddItem frmAddItem = new frmAddItem();

        

        #region Buttons

        //Add Item button code, pops a new instance of AddItem form 
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //frmAddItem.ShowDialog();
            using (var frmAddItem = new frmAddItem(this))
            {
                frmAddItem.ShowDialog();
            }
        }

        #endregion

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

        
    }
}
