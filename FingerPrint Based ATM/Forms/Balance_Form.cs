using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FingerPrint_Based_ATM.Account;
using FingerPrint_Based_ATM.Database;
namespace FingerPrint_Based_ATM.Forms
{
    public partial class Balance_Form : Form
    {
        public string serverName = @"ESLAMEZZAT\SQLEXPRESS";
        public string databaseName = "Finger";
        public static SqlConnection sqlConnection;
        public static string connectionString = "";
        public Balance_Form()
        {
            InitializeComponent();
            connectionString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }



        string lan = "";
        public void language(string lang)
        {
            lan = lang;
        }



        string fingerPrintNum = "";
        bool check = false;
        public void receiveFinger(string finger, bool checkAccount)
        {
            fingerPrintNum = finger;
            check = checkAccount;
        }
        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction_Form fr = new Transaction_Form();
            fr.receiveFinger(fingerPrintNum, check);
            fr.language(lan);
            fr.ShowDialog();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            this.Hide();
            PleaseWait_Form pleaseWait_Form = new PleaseWait_Form();
            pleaseWait_Form.ShowDialog();
            Ask_For_Receipt_Form ask_For_Receipt_Form = new Ask_For_Receipt_Form();
            ask_For_Receipt_Form.receivingValue(0, "Balance");
            ask_For_Receipt_Form.receiveFinger(fingerPrintNum, check);
            ask_For_Receipt_Form.language(lan);
            ask_For_Receipt_Form.ShowDialog();
        }
        bool checkCon = false;
        private void Balance_Form_Load(object sender, EventArgs e)
        {
            accountClass.transaction transaction = new accountClass.transaction();
            if (checkCon == false)
            {
                check = true;
                Connection connection = new Connection();
                connection.db_ConnectionToDatabase(false, sqlConnection);
            }
            try
            {
                SqlCommand sqlCommand;
                SqlDataReader sqlDataReader;
                string sql = "";
                if (lan == "en")
                {
                    sql = $"Select NAME from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        lbl_username.Text = sqlDataReader.GetValue(0).ToString();
                    }
                    sqlDataReader.Close();
                }
                else
                {
                    sql = $"Select NAMEARABIC from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        lbl_username.Text = sqlDataReader.GetValue(0).ToString();
                    }
                    sqlDataReader.Close();
                }
                sql = $"Select CURRENTBALANCE from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    lbl_amount.Text = sqlDataReader.GetValue(0).ToString();
                }
                sqlDataReader.Close();
                sql = $"Select ACCOUNTNUMBER from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    lbl_accountno.Text = sqlDataReader.GetValue(0).ToString();
                }
                sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
