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
using FingerPrint_Based_ATM.Database;
using System.Data.SqlClient;
namespace FingerPrint_Based_ATM.Forms
{
    public partial class Withdraw_2_Form : Form
    {
        public string serverName = @"ESLAMEZZAT\SQLEXPRESS";
        public string databaseName = "Finger";
        public static SqlConnection sqlConnection;
        public static string connectionString = "";
        public string checkA = "";
        public static string balanceV = "";
        public static double balance = 0;
        public Withdraw_2_Form()
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


        public void checkAccout(string check)
        {
            checkA = check;
        }


        string lan = "";
        public void language(string lang)
        {
            lan = lang;
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction_Form fr = new Transaction_Form();
            fr.receiveFinger(fingerPrintNum, check);
            fr.language(lan);
            fr.ShowDialog();
        }
        bool checkCon = false;
        private void btn_Enter_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text != "")
            {
                accountClass.transaction transaction = new accountClass.transaction();
                if (transaction.Withdraw(double.Parse(txtAmount.Text), balance))
                {
                    this.Hide();
                    PleaseWait_Form fr2 = new PleaseWait_Form();
                    fr2.ShowDialog();
                    //MessageBox.Show("Please Wait, Your Request is being executed");
                    Ask_For_Receipt_Form ask_For_Receipt_Form = new Ask_For_Receipt_Form();
                    ask_For_Receipt_Form.receiveFinger(fingerPrintNum, check);
                    ask_For_Receipt_Form.receivingValue(double.Parse(txtAmount.Text), "Withdraw");
                    ask_For_Receipt_Form.language(lan);
                    ask_For_Receipt_Form.ShowDialog();
                }
                else
                {
                    this.Hide();
                    TryAgen_Form fr3 = new TryAgen_Form();
                    fr3.receiveFinger(fingerPrintNum, check);
                    fr3.receiveForm("Withdraw");
                    fr3.language(lan);
                    fr3.ShowDialog();
                    //MessageBox.Show("You enterd amount greater than your balance,Please Try Again");
                }
            }
            else
            {
                //MessageBox.Show("Please,Fill The Box Of Amount");
                CheckAmountForm chkAmount = new CheckAmountForm();
                chkAmount.ShowDialog();
            }
        }

        private void Withdraw_2_Form_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtAmount;
            if (checkCon == false)
            {
                checkCon = true;
                Connection connection = new Connection();
                connection.db_ConnectionToDatabase(false, sqlConnection);
            }
            SqlCommand sqlCommand;
            SqlDataReader sqlDataReader;
            string sql = "";
            sql = $"Select CURRENTBALANCE from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                balanceV = (sqlDataReader.GetValue(0).ToString());
            }
            balance = double.Parse(balanceV);
            balanceLabel.Text = balance.ToString();
            sqlDataReader.Close();
            dateLabel.Text = DateTime.Now.ToString("d/M/yyyy");
            lblTime.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
