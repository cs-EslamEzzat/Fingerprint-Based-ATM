using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FingerPrint_Based_ATM.Database;
using System.Data.SqlClient;
namespace FingerPrint_Based_ATM.Forms
{
    public partial class Deposit_Form : Form
    {
        public double balance = 0;
        public string serverName = @"ESLAMEZZAT\SQLEXPRESS";
        public string databaseName = "Finger";
        public static SqlConnection sqlConnection;
        public static string connectionString = "";

        public Deposit_Form()
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
            if (txtAmount.Text == "")
            {
                CheckAmountForm chkAmount = new CheckAmountForm();
                chkAmount.ShowDialog();
            }
            else
            {
                this.Hide();
                PleaseWait_Form pleaseWait_Form = new PleaseWait_Form();
                pleaseWait_Form.ShowDialog();
                Ask_For_Receipt_Form ask_For_Receipt_Form = new Ask_For_Receipt_Form();
                ask_For_Receipt_Form.receivingValue(double.Parse(txtAmount.Text), "Deposit");
                ask_For_Receipt_Form.receiveFinger(fingerPrintNum, check);
                ask_For_Receipt_Form.language(lan);
                ask_For_Receipt_Form.ShowDialog();
            }
        }
        bool checkCon = false;
        private void Deposit_Form_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtAmount;
            if (checkCon == false)
            {
                checkCon = true;
                Connection connection = new Connection();
                connection.db_ConnectionToDatabase(false, sqlConnection);
            }
            lblDate.Text = DateTime.Now.ToString("dd/M/yyyy");
            lblTime.Text = DateTime.Now.ToString("hh:mm tt");
            SqlCommand sqlCommand;
            SqlDataReader sqlDataReader;
            string sql = "";
            sql = $"Select CURRENTBALANCE from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                lblBal.Text = sqlDataReader.GetValue(0).ToString();
            }
            sqlDataReader.Close();
        }
    }
}
