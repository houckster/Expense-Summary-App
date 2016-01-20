using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Summary_App
{
    public class Validation
    {
        //string to use in message boxes for the title
        private static string title = "Entry Error";

        //methood to get and set title string
        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        //method to check if text is a valid number
        public static bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a decimal value.", Title);
                textBox.Focus();
                return false;
            }
        }

        //method to check for a valid number range
        public static bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min.ToString() + " and " + max.ToString() + ".", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }
            
        //method to check for blank required fields
        public static bool ContainsData(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " cannot be blank. PLease fill in the textbox and resubmit.", Title);
                textBox.Focus();
                return false;
            }
            return true;
         }        
    }
}
