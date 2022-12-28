using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace FingerPrint_Based_ATM.Database
{
    public class Connection
    {
        public string serverName = @"ESLAMEZZAT\SQLEXPRESS";
        public string databaseName = "Finger";
        public string connectionString = "";
        public static SqlConnection sqlConnection;
        public bool db_ConnectionToDatabase(bool showMessage, SqlConnection sqlConnection)
        {
            try
            {
                sqlConnection.Open();
                if (showMessage)
                    MessageBox.Show("Successful database connection.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Database Connection");
                return false;
            }
        }

       
    }
}
