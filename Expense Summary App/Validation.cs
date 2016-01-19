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
        //method to check if text is a valid number
        public bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a decimal value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        //method to check for a valid number range
        public bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min.ToString() + " and " + max.ToString() + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
            
        //method to check for blank required fields
        public bool ContainsData(TextBox textBox, string name)
        {
            string textCheck = textBox.Text;
            if (textCheck != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " cannot be blank. PLease fill in the textbox and resubmit.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }
    }
}
