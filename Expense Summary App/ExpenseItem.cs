using System;
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
        //image -- TODO: figure out datatype for file later
        public string description;
        public string miles;
        public string expenseType;

        //***Constructor that takes 4 arguments to assign all properties for Expense Item object.
        public ExpenseItem (string date1, string description1, string miles1, string expenseType1)
        {
            date = date1;
            description = description1;
            miles = miles1;
            expenseType = expenseType1;
            //image = image1
        }

    }
}
