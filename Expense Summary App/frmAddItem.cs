﻿using System;
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

        //instantiate an instance of the main form
        public frmMain frmMain;

        //pass through reference to frmMain in frmAddItem so I can access the SendToGrid method from 
        //frmMain class
        public frmAddItem(frmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
        }

        #region Global Variables

        //initialize global variables used to calculate and assign readonly textboxes
        double rate = .575;
        double totalExpense = 0;
        
        #endregion

        #region Buttons and Checkbox
        //logic to hide and display appropriate sections on form based on the Need Mileage? checkbox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                lblSection.Text = "Mileage";
                btnCalculate.Visible = true;
                btnClear.Visible = true;
                btnAttachReceipt.Visible = false;
                lblReceiptDate.Visible = false;
                dtpReceiptDate.Visible = false;
                lblReceiptFile.Visible = false;
                txtReceiptFile.Visible = false;

            }

            if (checkBox1.Checked == false)
            {

                btnCalculate.Visible = false;
                btnClear.Visible = false;
                panel1.Visible = false;
                panel2.Visible = true;
                lblSection.Text = "Non Mileage Expense";
                txtTotalMiles.Text = "";
                txtMileageTotal.Text = "";
                btnAttachReceipt.Visible = true;
                lblReceiptDate.Visible = true;
                dtpReceiptDate.Visible = true;
                lblReceiptFile.Visible = true;
                txtReceiptFile.Visible = true;
                
            }
        }

        //calculate button click event 
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtRate.Text = "$0.575";
                txtExpenseCode.Text = "a";
                txtWriteInTotal.Text = "0";
                totalExpense = rate * Convert.ToDouble(txtTotalMiles.Text.ToString());
                txtTotalExpense.Text = totalExpense.ToString("c");
                txtMileageTotal.Text = totalExpense.ToString("c");
            }
        }

        //clear button click event
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtExpenseCode.Text = "";
            txtWriteInTotal.Text = "";
            txtTotalExpense.Text = "";
            txtMileageTotal.Text = "";
            txtTotalMiles.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //TODO: run validation methods from validation class

            //TODO: calculate and assign the values for the read-only values to be passed to object
            if (checkBox1.Checked == false)
            {
                txtMileageTotal.Text = "NA";
                txtTotalMiles.Text = "NA";
                txtRate.Text = "NA";
            }

            if (checkBox1.Checked == true)
            {
                txtWriteInTotal.Text = "";
            }

            totalExpense = Convert.ToDouble(txtWriteInTotal.Text);
            txtTotalExpense.Text = totalExpense.ToString("c"); 

            //assign the expense code based on the expense type selected
            switch (comboBox1.Text)
            {
                case "meals & entertainment":
                    txtExpenseCode.Text = "m";
                    break;
                case "employee vehicle auto reimbursment":
                    txtExpenseCode.Text = "a";
                    break;
                case "company vehicle fuel":
                    txtExpenseCode.Text = "f";
                    break;
                case "company vehicle repairs & maintance":
                    txtExpenseCode.Text = "rm";
                    break;
                case "employee relations":
                    txtExpenseCode.Text = "e";
                    break;
                case "travel, cab fare, car rental, etc.":
                    txtExpenseCode.Text = "t";
                    break;
                case "Selling Telecommunicatons":
                    txtExpenseCode.Text = "o";
                    break;
                case "1 - other expenses to be itemized":
                    txtExpenseCode.Text = "o1";
                    break;
                case "2 - other expenses to be itemized":
                    txtExpenseCode.Text = "o2";
                    break;
                case "3 - other expenses to be itemized":
                    txtExpenseCode.Text = "o3";
                    break;
                case "4 - other expenses to be itemized":
                    txtExpenseCode.Text = "o4";
                    break;
            }


            /*Instantiate an object instance of the ExpenseItem class using the 8 argument contructor, 
            pulling in the values from the form*/
            ExpenseItem expenseItem = new ExpenseItem(dtpReceiptDate.Text.ToString(), 
            txtDescription.Text.ToString(), txtTotalMiles.Text.ToString(), comboBox1.Text.ToString(), 
            txtExpenseCode.Text.ToString(), txtRate.Text.ToString(), txtTotalExpense.Text.ToString(), 
            txtMileageTotal.Text.ToString());

            
            //call the method from the main form to send the object property values to the data 
            //grid view on form one
            frmMain.SendToGrid(expenseItem);
            this.Close();
                     
        }

        //This event handler can be removed - accidental double click
        private void frmAddItem_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //TODO: pop a message box saying that all data will not be saved, if OK, then close, 
            //other wise remain on form
            this.Close();
        }

        #endregion

        }

}