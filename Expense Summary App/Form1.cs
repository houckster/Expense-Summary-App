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

        #region Buttons

        //Add Item button code, pops a new instance of 
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmAddItem frmAddItem  = new frmAddItem();
            frmAddItem.ShowDialog();
        }

        #endregion
    }
}
