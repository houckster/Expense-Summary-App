﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense_Summary_App
{
    public class ExpenseItem
    {
        //***set the properties for the ExpenseItem object
        public string date;
        public string description;
        public string miles;
        public string expenseType;
        public string expenseCode;
        public string rate;
        public string totalExpense;
        public string mileageTotal;
        public System.Drawing.Image receiptImage = null;

        //***Constructor that takes 8 arguments to assign all properties for Expense Item object.
        public ExpenseItem (string date1, string description1, string miles1, string expenseType1, 
        string expenseCode1, string rate1, string totalExpense1, string mileageTotal1, System.Drawing.Image receiptImage1)
        {
            date = date1;
            description = description1;
            miles = miles1;
            expenseType = expenseType1;
            expenseCode = expenseCode1;
            rate = rate1;
            totalExpense = totalExpense1;
            mileageTotal = mileageTotal1;
            receiptImage = receiptImage1;
        }
    }
}
