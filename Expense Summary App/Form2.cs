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
    public partial class frmAddItem : Form
    {
        public frmAddItem()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtTotalMiles.Visible = true;
                lblTotalMiles.Visible = true;
            }
            else
            {
                txtTotalMiles.Visible = false;
                lblTotalMiles.Visible = false;
                txtTotalMiles.Text = "";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            /*Instantiate an object instance of the ExpenseItem class using the 4 argument contructor, 
            pulling in the values from the form*/
            ExpenseItem expenseItem = new ExpenseItem(dateTimePicker1.ToString(), txtDescription.Text.ToString(), txtTotalMiles.Text.ToString(), comboBox1.Text.ToString());
            this.Close();
        }
    }
    
}
