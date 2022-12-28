using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FingerPrint_Based_ATM.Database;

namespace FingerPrint_Based_ATM.Forms
{
    public partial class ChkTransfirForm : Form
    {
        public string balance = "";
        public string checkAccount = "";
        public string serverName = @"ESLAMEZZAT\SQLEXPRESS";
        public string databaseName = "Finger";
        public static SqlConnection sqlConnection;
        public static string connectionString = "";
        public ChkTransfirForm()
        {
            InitializeComponent();
            connectionString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }


        string fingerPrintNum = "";
        bool check = false;
        public void receiveFinger(string finger, bool checkAccount)
        {
            fingerPrintNum = finger;
            check = checkAccount;
        }


        public double Value = 0;
        public string checkButton = "";
        public void receivingValues(double value, string check)
        {
            Value = value;
            checkButton = check;
        }
        int x;
        public void receiveAccountNum(int accountNumber)
        {
            x = accountNumber;
        }
        bool checkCon = false;

        string lan = "";
        public void language(string lang)
        {
            lan = lang;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Hide();
            End_Form fr = new End_Form();
            fr.checkAccount(checkAccount);
            fr.receiveFinger(fingerPrintNum, check);
            fr.language(lan);
            fr.ShowDialog();
        }

        private void ChkTransfirForm_Load(object sender, EventArgs e)
        {
            if (checkCon == false)
            {
                check = true;
                Connection connection = new Connection();
                connection.db_ConnectionToDatabase(false, sqlConnection);
            }
            lblDate.Text = DateTime.Now.ToString("dd/M/yyyy");
            lblTime.Text = DateTime.Now.ToString("hh:mm tt");
            lblTransfer.Text = Value.ToString();
            lblAccount.Text = x.ToString();
            try
            {
                SqlCommand sqlCommand;
                SqlDataReader sqlDataReader;
                string sql = "";
                if (lan == "en")
                {
                    sql = $"Select NAME from [ACCOUNT] WHERE AccountNumber = {x}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        lblName.Text = sqlDataReader.GetValue(0).ToString();
                    }
                    sqlDataReader.Close();
                }
                else
                {
                    sql = $"Select NAMEARABIC from [ACCOUNT] WHERE AccountNumber = {x}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        lblName.Text = sqlDataReader.GetValue(0).ToString();
                    }
                    sqlDataReader.Close();
                }
                sql = $"Select CURRENTBALANCE from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                string newValue1 = "";
                string newValue2 = "";
                while (sqlDataReader.Read())
                {
                    newValue1 = sqlDataReader.GetValue(0).ToString();
                }
                sqlDataReader.Close();
                sql = $"Select CURRENTBALANCE from [ACCOUNT] WHERE AccountNumber = {x}";
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    newValue2 = sqlDataReader.GetValue(0).ToString();
                }
                sqlDataReader.Close();
                sql = $"Update [ACCOUNT] set CURRENTBALANCE = {(int.Parse(newValue1) - Value)} WHERE FINGERPRINT = {fingerPrintNum}";
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sql = $"Update [ACCOUNT] set CURRENTBALANCE = {(int.Parse(newValue2) + Value)} WHERE AccountNumber = {x}";
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

