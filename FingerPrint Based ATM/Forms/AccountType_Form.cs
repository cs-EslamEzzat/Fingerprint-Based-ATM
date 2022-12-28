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
    public partial class AccountType_Form : Form
    {
        /// <summary>
        /// Method that Showing Transaction of each Account(credit,Current,Savings)
        /// </summary>
        /// <param name="form"></param>
        /* public static void accountTransactionShowing(Form form, string checkAccount)
         {
             form.Hide();
             Transaction_Form fr = new Transaction_Form();
             fr.checkAccount(checkAccount);
             fr.ShowDialog();
         }*/



        string lan = "";
        public void language(string lang)
        {
            lan = lang;
        }

        public string serverName = @"ESLAMEZZAT\SQLEXPRESS";
        public string databaseName = "Finger";
        public static SqlConnection sqlConnection;
        public static string connectionString = "";
        public AccountType_Form()
        {
            InitializeComponent();
            connectionString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }

        /// <summary>
        /// Logout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Language_Form fr = new Language_Form();
            fr.checkSerial(true);
            fr.ShowDialog();
        }

        string fingerPrintNum = "";
        public void receiveFinger(string finger)
        {
            fingerPrintNum = finger;
        }
        /// <summary>
        /// Current Account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        bool check = false;
        bool checkAccount = false;
        public void btn_current_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                check = true;
                Connection connection = new Connection();
                connection.db_ConnectionToDatabase(false, sqlConnection);
            }
            try
            {
                if (lan == "en")
                {
                    SqlCommand sqlCommand;
                    SqlDataReader sqlDataReader;
                    string sql = "", output = "";
                    sql = $"Select AccountType from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        output = sqlDataReader.GetValue(0).ToString();
                        if (output == "Current Account")
                        {
                            checkAccount = true;
                            break;
                        }
                        else
                        {
                            Check_AccounType_Form check_AccounType_Form = new Check_AccounType_Form();
                            check_AccounType_Form.language(lan);
                            check_AccounType_Form.receiveFinger(fingerPrintNum,"Current Account");
                            check_AccounType_Form.ShowDialog();
                        }
                    }
                    sqlDataReader.Close();
                }
                else
                {
                    SqlCommand sqlCommand;
                    SqlDataReader sqlDataReader;
                    string sql = "", output = "";
                    sql = $"Select AccountTypeArabic from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        output = sqlDataReader.GetValue(0).ToString();
                        if (output == "حساب جاري ")
                        {
                            checkAccount = true;
                            break;
                        }
                        else
                        {
                            Check_AccounType_Form check_AccounType_Form = new Check_AccounType_Form();
                            check_AccounType_Form.language(lan);
                            check_AccounType_Form.receiveFinger(fingerPrintNum,"حساب جاري");
                            check_AccounType_Form.ShowDialog();
                        }
                    }
                    sqlDataReader.Close();
                }
                if (checkAccount)
                {
                    this.Hide();
                    PleaseWait_Form pleaseWait_Form = new PleaseWait_Form();
                    pleaseWait_Form.ShowDialog();
                    Transaction_Form fr = new Transaction_Form();
                    fr.receiveFinger(fingerPrintNum, checkAccount);
                    fr.language(lan);
                    fr.ShowDialog();
                    checkAccount = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Credit Account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btn_credit_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                check = true;
                Connection connection = new Connection();
                connection.db_ConnectionToDatabase(false, sqlConnection);
            }
            try
            {
                if (lan == "en")
                {
                    SqlCommand sqlCommand;
                    SqlDataReader sqlDataReader;
                    string sql = "", output = "";
                    sql = $"Select AccountType from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        output = sqlDataReader.GetValue(0).ToString();
                        if (output == "Credit Account")
                        {
                            checkAccount = true;
                            break;
                        }
                        else
                        {
                            Check_AccounType_Form check_AccounType_Form = new Check_AccounType_Form();
                            check_AccounType_Form.language(lan);
                            check_AccounType_Form.receiveFinger(fingerPrintNum,"Credit Account");
                            check_AccounType_Form.ShowDialog();
                        }

                    }
                    sqlDataReader.Close();
                }
                else
                {
                    SqlCommand sqlCommand;
                    SqlDataReader sqlDataReader;
                    string sql = "", output = "";
                    sql = $"Select AccountTypeArabic from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        output = sqlDataReader.GetValue(0).ToString();
                        if (output == "حساب ائتمان ")
                        {
                            checkAccount = true;
                            break;
                        }
                        else
                        {
                            Check_AccounType_Form check_AccounType_Form = new Check_AccounType_Form();
                            check_AccounType_Form.language(lan);
                            check_AccounType_Form.receiveFinger(fingerPrintNum,"حساب ائتمان");
                            check_AccounType_Form.ShowDialog();
                        }
                    }
                    sqlDataReader.Close();
                }
                if (checkAccount)
                {
                    this.Hide();
                    PleaseWait_Form pleaseWait_Form = new PleaseWait_Form();
                    pleaseWait_Form.ShowDialog();
                    Transaction_Form fr = new Transaction_Form();
                    fr.receiveFinger(fingerPrintNum, checkAccount);
                    fr.language(lan);
                    fr.ShowDialog();
                    checkAccount = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Savings Account 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btn_Saving_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                check = true;
                Connection connection = new Connection();
                connection.db_ConnectionToDatabase(false, sqlConnection);
            }
            try
            {
                if (lan == "en")
                {
                    SqlCommand sqlCommand;
                    SqlDataReader sqlDataReader;
                    string sql = "", output = "";
                    sql = $"Select AccountType from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        output = sqlDataReader.GetValue(0).ToString();
                        if (output == "Saving Account")
                        {
                            checkAccount = true;
                            break;
                        }
                        else
                        {
                            Check_AccounType_Form check_AccounType_Form = new Check_AccounType_Form();
                            check_AccounType_Form.language(lan);
                            check_AccounType_Form.receiveFinger(fingerPrintNum,"Saving Account");
                            check_AccounType_Form.ShowDialog();
                        }
                    }
                    sqlDataReader.Close();
                }
                else
                {
                    SqlCommand sqlCommand;
                    SqlDataReader sqlDataReader;
                    string sql = "", output = "";
                    sql = $"Select AccountTypeArabic from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        output = sqlDataReader.GetValue(0).ToString();
                        if (output == "حساب توفير ")
                        {
                            checkAccount = true;
                            break;
                        }
                        else
                        {
                            Check_AccounType_Form check_AccounType_Form = new Check_AccounType_Form();
                            check_AccounType_Form.language(lan);
                            check_AccounType_Form.receiveFinger(fingerPrintNum,"حساب توفير");
                            check_AccounType_Form.ShowDialog();
                        }
                    }
                    sqlDataReader.Close();
                }
                if (checkAccount)
                {
                    this.Hide();
                    PleaseWait_Form pleaseWait_Form = new PleaseWait_Form();
                    pleaseWait_Form.ShowDialog();
                    Transaction_Form fr = new Transaction_Form();
                    fr.receiveFinger(fingerPrintNum, checkAccount);
                    fr.language(lan);
                    fr.ShowDialog();
                    checkAccount = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AccountType_Form_Load(object sender, EventArgs e)
        {
            checkAccount = false;
        }
    }
}
