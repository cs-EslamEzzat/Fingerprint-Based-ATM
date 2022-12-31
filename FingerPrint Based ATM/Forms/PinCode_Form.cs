using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.SqlClient;
using FingerPrint_Based_ATM.Database;
namespace FingerPrint_Based_ATM.Forms
{
    public partial class PinCode_Form : Form
    {
        public string serverName = @"ESLAMEZZAT\SQLEXPRESS";
        public string databaseName = "Finger";
        public static SqlConnection sqlConnection;
        public static string connectionString = "";
        public PinCode_Form()
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



        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Language_Form fr = new Language_Form();
            fr.checkSerial(true);
            fr.ShowDialog();
        }
        string fingerPrintNum;
        public void receiveFinger(string finger)
        {
            fingerPrintNum = finger;
        }
        bool check = false;
        private void btn_Enter_Click(object sender, EventArgs e)
        {
            if (pinCode.Text != "")
            {
                if (check == false)
                {
                    check = true;
                    Connection connection = new Connection();
                    connection.db_ConnectionToDatabase(false, sqlConnection);
                }
                SqlCommand sqlCommand;
                SqlDataReader sqlDataReader;
                string sql = "", output = "";
                sql = $"Select PINCODE from [BANK] WHERE FINGERPRINT = {fingerPrintNum}";
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                bool checkPinCode = false;
                while (sqlDataReader.Read())
                {
                    output = sqlDataReader.GetValue(0).ToString();
                    if (output == (pinCode.Text.ToString()))
                    {
                        checkPinCode = true;
                        Operating_Load_Form f1 = new Operating_Load_Form();
                        f1.ShowDialog();
                        this.Hide();
                        AccountType_Form fr = new AccountType_Form();
                        fr.receiveFinger(fingerPrintNum);
                        fr.language(lan);
                        fr.ShowDialog();
                        break;
                    }
                }
                sqlDataReader.Close();
                if (!checkPinCode)
                {
                    pinCode.Clear();
                    Erorr_PinCode_orm f1 = new Erorr_PinCode_orm();
                    f1.ShowDialog();
                    //MessageBox.Show("You Entered Wrong Passowrd,Try Again");
                }
            }
            else
            {

                CheckPinCodeForm chkForm = new CheckPinCodeForm();
                chkForm.ShowDialog();
                //MessageBox.Show("Please,Fill The Box Of PinCode");
            }
            this.ActiveControl = pinCode;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            pinCode.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PinCode_Form_Load(object sender, EventArgs e)
        {
            this.ActiveControl = pinCode;
        }

        private void pinCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (check == false)
                {
                    check = true;
                    Connection connection = new Connection();
                    connection.db_ConnectionToDatabase(false, sqlConnection);
                }
                SqlCommand sqlCommand;
                SqlDataReader sqlDataReader;
                string sql = "", output = "";
                sql = $"Select PINCODE from [BANK] WHERE FINGERPRINT = {fingerPrintNum}";
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                bool checkPinCode = false;
                while (sqlDataReader.Read())
                {
                    output = sqlDataReader.GetValue(0).ToString();
                    if (output == (pinCode.Text.ToString()))
                    {
                        checkPinCode = true;
                        Operating_Load_Form f1 = new Operating_Load_Form();
                        f1.ShowDialog();
                        this.Hide();
                        AccountType_Form fr = new AccountType_Form();
                        fr.receiveFinger(fingerPrintNum);
                        fr.language(lan);
                        fr.ShowDialog();
                        break;
                    }
                }
                sqlDataReader.Close();
                if (!checkPinCode)
                {
                    pinCode.Clear();
                    Erorr_PinCode_orm f1 = new Erorr_PinCode_orm();
                    f1.ShowDialog();
                    //MessageBox.Show("You Entered Wrong Passowrd,Try Again");
                }
                this.ActiveControl = pinCode;
            }
        }
    }
}
