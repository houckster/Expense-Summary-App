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
    }
}
