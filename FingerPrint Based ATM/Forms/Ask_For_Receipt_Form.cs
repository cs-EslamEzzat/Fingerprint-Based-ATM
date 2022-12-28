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
    public partial class Ask_For_Receipt_Form : Form
    {
        public string checkA = "";
        public string serverName = @"ESLAMEZZAT\SQLEXPRESS";
        public string databaseName = "Finger";
        public static SqlConnection sqlConnection;
        public static string connectionString = "";

        public Ask_For_Receipt_Form()
        {
            InitializeComponent();
            connectionString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }
        public double value = 0;
        public string typeOfTransaction = "";
        public void receivingValue(double value, string typeOftransacation)
        {
            this.value = value;
            this.typeOfTransaction = typeOftransacation;
        }

        int accountNum = 0;
        public void receiveAccountNum(int acc)
        {
            accountNum = acc;
        }
        public void showingReceipt(Form form)
        {
            form.Hide();
            form.ShowDialog();
        }
        string fingerPrintNum = "";
        bool check = false;
        public void receiveFinger(string finger, bool checkAccount)
        {
            fingerPrintNum = finger;
            check = checkAccount;
        }


        string lan = "";
        public void language(string lang)
        {
            lan = lang;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (typeOfTransaction == "Transfer")
            {
                ChkTransfirForm re = new ChkTransfirForm();
                re.receiveFinger(fingerPrintNum, check);
                re.receiveAccountNum(accountNum);
                re.receivingValues(value, "Transfer");
                re.language(lan);
                re.ShowDialog();
            }
            else
            {
                Receipt_Form re = new Receipt_Form();
                re.receiveFinger(fingerPrintNum, check);
                re.receiveAccountNum(accountNum);
                re.receivingValues(value, typeOfTransaction);
                re.language(lan);
                re.ShowDialog();
            }
        }

        bool checkCon = false;
        private void No_Click(object sender, EventArgs e)
        {
            this.Hide();
            SqlCommand sqlCommand;
            SqlDataReader sqlDataReader;
            string sql = "";
            string balance = "0";
            if (checkCon == false)
            {
                check = true;
                Connection connection = new Connection();
                connection.db_ConnectionToDatabase(false, sqlConnection);
            }
            if (typeOfTransaction == "Withdraw")
            {
                try
                {
                    sql = $"Select CURRENTBALANCE from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        balance = sqlDataReader.GetValue(0).ToString();
                    }
                    sqlDataReader.Close();
                    sql = $"Update [ACCOUNT] set CURRENTBALANCE = {(double.Parse(balance) - value)} WHERE FINGERPRINT = {fingerPrintNum}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (typeOfTransaction == "Deposit")
            {
                try
                {
                    sql = $"Select CURRENTBALANCE from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        balance = sqlDataReader.GetValue(0).ToString();
                    }
                    sqlDataReader.Close();
                    sql = $"Update [ACCOUNT] set CURRENTBALANCE = {(double.Parse(balance) + value)} WHERE FINGERPRINT = {fingerPrintNum}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (typeOfTransaction == "Transfer")
            {
                try
                {
                    sql = $"Select CURRENTBALANCE from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        balance = sqlDataReader.GetValue(0).ToString();
                    }
                    sqlDataReader.Close();
                    sql = $"Update [ACCOUNT] set CURRENTBALANCE = {(int.Parse(balance) - value)} WHERE FINGERPRINT = {fingerPrintNum}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sql = $"Select CURRENTBALANCE from [ACCOUNT] WHERE ACCOUNTNUMBER = {accountNum}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        balance = sqlDataReader.GetValue(0).ToString();
                    }
                    sqlDataReader.Close();
                    sql = $"Update [ACCOUNT] set CURRENTBALANCE = {(double.Parse(balance) + value)} WHERE ACCOUNTNUMBER = {accountNum}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlCommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            End_Form end_Form = new End_Form();
            end_Form.receiveFinger(fingerPrintNum, check);
            end_Form.language(lan);
            end_Form.ShowDialog();
        }
    }
}
