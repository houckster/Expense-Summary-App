using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Expense_Summary_App
{
    public static class ExpenseItemsDB 
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                    "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|" +
                        "\\ExpenseItems.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        public static ExpenseItem GetExpenseItem(int Id) 
        {
            SqlConnection connection = ExpenseItemsDB.GetConnection();
            string selectStatement
                = "SELECT * " +
                "FROM table_ExpenseItems " +
                "WHERE Id = @Id";
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@Id", Id);
            try
            {

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

