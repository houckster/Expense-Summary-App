using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Expense_Summary_App
{
    public static class ConnectionDB
    {
        public static SqlConnection GetConnection()
        {
        string connectionString = 
                "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|" +
                    "\\ExpenseItems.mdf;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        return connection;
        }
    }
}
