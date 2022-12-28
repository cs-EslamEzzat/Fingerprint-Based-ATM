using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FingerPrint_Based_ATM.Account;
using System.Data.SqlClient;
using FingerPrint_Based_ATM.Database;
namespace FingerPrint_Based_ATM.Forms
{
    public partial class Receipt_Form : Form
    {
        public string balance = "";
        public string checkAccount = "";
        public string serverName = @"ESLAMEZZAT\SQLEXPRESS";
        public string databaseName = "Finger";
        public static SqlConnection sqlConnection;
        public static string connectionString = "";
        public Receipt_Form()
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
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.Hide();
            End_Form fr = new End_Form();
            fr.checkAccount(checkAccount);
            fr.receiveFinger(fingerPrintNum, check);
            fr.language(lan);
            fr.ShowDialog();
        }
        bool checkCon = false;

        string lan = "";
        public void language(string lang)
        {
            lan = lang;
        }

        public void Receipt_Form_Load(object sender, EventArgs e)
        {
            if (checkCon == false)
            {
                check = true;
                Connection connection = new Connection();
                connection.db_ConnectionToDatabase(false, sqlConnection);
            }
            if (checkButton == "Withdraw")
            {
                lbldate.Text = DateTime.Now.ToString("dd/M/yyyy");
                lblwith.Text = Value.ToString();
                lblTime.Text = DateTime.Now.ToString("hh:mm tt");
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
                            lblname.Text = sqlDataReader.GetValue(0).ToString();
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
                            lblname.Text = sqlDataReader.GetValue(0).ToString();
                        }
                        sqlDataReader.Close();
                    }
                    sql = $"Select CURRENTBALANCE from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        lblbal.Text = sqlDataReader.GetValue(0).ToString();
                    }
                    sqlDataReader.Close();
                    sql = $"Update [ACCOUNT] set CURRENTBALANCE = {(int.Parse(lblbal.Text) - Value)} WHERE FINGERPRINT = {fingerPrintNum}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand = new SqlCommand($"Select CURRENTBALANCE from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}", sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        lblnewbal.Text = sqlDataReader.GetValue(0).ToString();
                    }
                    sqlDataReader.Close();
                    if (lan == "en")
                    {
                        sql = $"Select AccountType from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                        sqlCommand = new SqlCommand(sql, sqlConnection);
                        sqlDataReader = sqlCommand.ExecuteReader();
                        while (sqlDataReader.Read())
                        {
                            lblTypeOfAccount.Text = sqlDataReader.GetValue(0).ToString();
                        }
                        sqlDataReader.Close();
                    }
                    else
                    {
                        sql = $"Select AccountTypeArabic from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                        sqlCommand = new SqlCommand(sql, sqlConnection);
                        sqlDataReader = sqlCommand.ExecuteReader();
                        while (sqlDataReader.Read())
                        {
                            lblTypeOfAccount.Text = sqlDataReader.GetValue(0).ToString();
                        }
                        sqlDataReader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                lbldep.Text = "*****";
            }
            else if (checkButton == "Balance")
            {
                accountClass.transaction transaction = new accountClass.transaction();
                lbldate.Text = DateTime.Now.ToString("dd/M/yyyy");
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
                            lblname.Text = sqlDataReader.GetValue(0).ToString();
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
                            lblname.Text = sqlDataReader.GetValue(0).ToString();
                        }
                        sqlDataReader.Close();
                    }
                    sql = $"Select CURRENTBALANCE from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        lblbal.Text = sqlDataReader.GetValue(0).ToString();
                    }
                    sqlDataReader.Close();
                    lblTime.Text = DateTime.Now.ToString("hh:mm tt");
                    lblwith.Text = "****";
                    lbldep.Text = "****";
                    lblnewbal.Text = "****";
                    if (lan == "en")
                    {
                        sql = $"Select AccountType from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                        sqlCommand = new SqlCommand(sql, sqlConnection);
                        sqlDataReader = sqlCommand.ExecuteReader();
                        while (sqlDataReader.Read())
                        {
                            lblTypeOfAccount.Text = sqlDataReader.GetValue(0).ToString();
                        }
                        sqlDataReader.Close();
                    }
                    else
                    {
                        sql = $"Select AccountTypeArabic from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                        sqlCommand = new SqlCommand(sql, sqlConnection);
                        sqlDataReader = sqlCommand.ExecuteReader();
                        while (sqlDataReader.Read())
                        {
                            lblTypeOfAccount.Text = sqlDataReader.GetValue(0).ToString();
                        }
                        sqlDataReader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (checkButton == "Deposit")
            {
                lbldep.Text = Value.ToString();
                lbldate.Text = DateTime.Now.ToString("dd/M/yyyy");
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
                            lblname.Text = sqlDataReader.GetValue(0).ToString();
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
                            lblname.Text = sqlDataReader.GetValue(0).ToString();
                        }
                        sqlDataReader.Close();
                    }
                    sql = $"Select CURRENTBALANCE from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        lblbal.Text = sqlDataReader.GetValue(0).ToString();
                    }
                    sqlDataReader.Close();
                    sql = $"Update [ACCOUNT] set CURRENTBALANCE = {(double.Parse(lblbal.Text) + Value)} WHERE FINGERPRINT = {fingerPrintNum}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand = new SqlCommand($"Select CURRENTBALANCE from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}", sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        lblnewbal.Text = sqlDataReader.GetValue(0).ToString();
                    }
                    sqlDataReader.Close();
                    if (lan == "en")
                    {
                        sql = $"Select AccountType from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                        sqlCommand = new SqlCommand(sql, sqlConnection);
                        sqlDataReader = sqlCommand.ExecuteReader();
                        while (sqlDataReader.Read())
                        {
                            lblTypeOfAccount.Text = sqlDataReader.GetValue(0).ToString();
                        }
                        sqlDataReader.Close();
                    }
                    else
                    {
                        sql = $"Select AccountTypeArabic from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                        sqlCommand = new SqlCommand(sql, sqlConnection);
                        sqlDataReader = sqlCommand.ExecuteReader();
                        while (sqlDataReader.Read())
                        {
                            lblTypeOfAccount.Text = sqlDataReader.GetValue(0).ToString();
                        }
                        sqlDataReader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                lblTime.Text = DateTime.Now.ToString("hh:mm tt");
                lblwith.Text = "****";
            }

        }
    }
}
