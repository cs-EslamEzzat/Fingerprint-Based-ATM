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
    public partial class Transfer_Form : Form
    {
        public string checkA = "";
        public string serverName = @"ESLAMEZZAT\SQLEXPRESS";
        public string databaseName = "Finger";
        public static SqlConnection sqlConnection;
        public static string connectionString = "";
        public Transfer_Form()
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

        string acc = "";
        public void receivAcc(string acc)
        {
            this.acc = acc;
        }


        public void checkAccount(string check)
        {
            checkA = check;
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
            if (checkCon == false)
            {
                checkCon = true;
                Connection connection = new Connection();
                connection.db_ConnectionToDatabase(false, sqlConnection);
            }
            try
            {
                if (txt_accnum.Text == "" && txt_amount.Text == "")
                {
                    //MessageBox.Show("Please,Fill The Box Of Account Number And Amount");
                    CheckAccountAndAmountForm chkAccAmount = new CheckAccountAndAmountForm();
                    chkAccAmount.ShowDialog();
                    return;
                }
                else if (txt_accnum.Text == "")
                {
                    //MessageBox.Show("Please,Fill The Box Of Account Number");
                    CheckAccountNumberForm chkAccountNum = new CheckAccountNumberForm();
                    chkAccountNum.ShowDialog();
                    return;
                }
                else if (txt_amount.Text == "")
                {
                    //MessageBox.Show("Please,Fill The Box Of Amount");
                    CheckAmountForm chkAmount = new CheckAmountForm();
                    chkAmount.ShowDialog();
                    return;
                }
                SqlCommand sqlCommand;
                SqlDataReader sqlDataReader;
                string sql = "";
                string accountNumber = "";
                string acco = "";
                int acc = int.Parse(txt_accnum.Text);
                sql = $"Select NAME from [ACCOUNT] WHERE ACCOUNTNUMBER = {acc}";
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    acco = sqlDataReader.GetValue(0).ToString();
                }
                sqlDataReader.Close();
                sql = $"Select AccountNumber from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    accountNumber = sqlDataReader.GetValue(0).ToString();
                }
                sqlDataReader.Close();
                if (acco == "")
                {
                    Erorr_Acco_Transfer_Form f1 = new Erorr_Acco_Transfer_Form();
                    f1.ShowDialog();
                }
                else if (accountNumber == acc.ToString() || accountNumber == "")
                {
                    Erorr_Acco_Transfer_Form f1 = new Erorr_Acco_Transfer_Form();
                    f1.ShowDialog();
                }
                else
                {
                    PleaseWait_Form pleaseWait_Form = new PleaseWait_Form();
                    pleaseWait_Form.ShowDialog();
                    if (int.Parse((lbl_bal.Text)) >= int.Parse(txt_amount.Text))
                    {
                        this.Hide();
                        Chek_Transfer_Form check_Transfer = new Chek_Transfer_Form();
                        check_Transfer.receiveFinger(fingerPrintNum, check);
                        check_Transfer.receiveAccountNum(int.Parse(txt_accnum.Text));
                        check_Transfer.receivingValue(double.Parse(txt_amount.Text), "Transfer");
                        check_Transfer.language(lan);
                        check_Transfer.ShowDialog();
                    }
                    else
                    {
                        this.Hide();
                        TryAgen_Form tryAgen_Form = new TryAgen_Form();
                        tryAgen_Form.receiveFinger(fingerPrintNum, check);
                        tryAgen_Form.receiveForm("Transfer");
                        tryAgen_Form.language(lan);
                        tryAgen_Form.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Transfer_Form_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txt_accnum;
            if (checkCon == false)
            {
                checkCon = true;
                Connection connection = new Connection();
                connection.db_ConnectionToDatabase(false, sqlConnection);
            }
            try
            {
                SqlCommand sqlCommand;
                SqlDataReader sqlDataReader;
                string sql = "";
                sql = $"Select CURRENTBALANCE from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    lbl_bal.Text = sqlDataReader.GetValue(0).ToString();
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
