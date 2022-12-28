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
    public partial class Transaction_Form : Form
    {
        public string serverName = @"ESLAMEZZAT\SQLEXPRESS";
        public string databaseName = "Finger";
        public static SqlConnection sqlConnection;
        public static string connectionString = "";
        public Transaction_Form()
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
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            PleaseWait_Form pleaseWait_Form = new PleaseWait_Form();
            pleaseWait_Form.ShowDialog();
            AccountType_Form fr = new AccountType_Form();
            fr.receiveFinger(fingerPrintNum);
            fr.language(lan);
            fr.ShowDialog();
        }

        public void btn_Withdraw_Click(object sender, EventArgs e)
        {
            this.Hide();
            PleaseWait_Form pleaseWait_Form = new PleaseWait_Form();
            pleaseWait_Form.ShowDialog();
            Withdraw_1_Form fr = new Withdraw_1_Form();
            fr.receiveFinger(fingerPrintNum, check);
            fr.language(lan);
            fr.ShowDialog();
        }

        private void btn_Deposit_Click(object sender, EventArgs e)
        {
            this.Hide();
            PleaseWait_Form pleaseWait_Form = new PleaseWait_Form();
            pleaseWait_Form.ShowDialog();
            Deposit_Form fr = new Deposit_Form();
            fr.receiveFinger(fingerPrintNum, check);
            fr.language(lan);
            fr.ShowDialog();
        }






        private void btn_Balance_Click(object sender, EventArgs e)
        {
            this.Hide();
            PleaseWait_Form pleaseWait_Form = new PleaseWait_Form();
            pleaseWait_Form.ShowDialog();
            Balance_Form fr = new Balance_Form();
            fr.receiveFinger(fingerPrintNum, check);
            fr.language(lan);
            fr.ShowDialog();
        }

        private void btn_Transfer_Click(object sender, EventArgs e)
        {
            this.Hide();
            PleaseWait_Form pleaseWait_Form = new PleaseWait_Form();
            pleaseWait_Form.ShowDialog();
            Transfer_Form fr = new Transfer_Form();
            fr.receiveFinger(fingerPrintNum, check);
            fr.receivAcc(lblaccno.Text);
            fr.language(lan);
            fr.ShowDialog();
        }
        bool checkCon = false;


        string lan = "";
        public void language(string lang)
        {
            lan = lang;
        }
        private void Transaction_Form_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd/M/yyyy");
            lblTime.Text = DateTime.Now.ToString("hh:mm tt");
            if (checkCon == false)
            {
                check = true;
                Connection connection = new Connection();
                connection.db_ConnectionToDatabase(false, sqlConnection);
            }
            if (lan == "en")
            {
                try
                {
                    SqlCommand sqlCommand;
                    SqlDataReader sqlDataReader;
                    string sql = "";
                    sql = $"Select NAME from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        lblname.Text = sqlDataReader.GetValue(0).ToString();
                    }
                    sqlDataReader.Close();
                    sql = $"Select ACCOUNTNUMBER from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        lblaccno.Text = sqlDataReader.GetValue(0).ToString();
                    }
                    sqlDataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                SqlCommand sqlCommand;
                SqlDataReader sqlDataReader;
                string sql = "";
                sql = $"Select NAMEARABIC from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    lblname.Text = sqlDataReader.GetValue(0).ToString();
                }
                sqlDataReader.Close();
                sql = $"Select ACCOUNTNUMBER from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    lblaccno.Text = sqlDataReader.GetValue(0).ToString();
                }
                sqlDataReader.Close();
            }
        }
    }
}
