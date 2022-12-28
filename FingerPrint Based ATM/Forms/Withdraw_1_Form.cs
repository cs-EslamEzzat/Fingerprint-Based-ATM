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
using System.Threading;
namespace FingerPrint_Based_ATM.Forms
{
    public partial class Withdraw_1_Form : Form
    {
        public string valueOfBalance = "";
        public double balance = 0;
        public string serverName = @"ESLAMEZZAT\SQLEXPRESS";
        public string databaseName = "Finger";
        public static SqlConnection sqlConnection;
        public static string connectionString = "";

        public Withdraw_1_Form()
        {
            InitializeComponent();
            connectionString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }
        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction_Form fr = new Transaction_Form();
            fr.receiveFinger(fingerPrintNum, check);
            fr.language(lan);
            fr.ShowDialog();
        }

        string lan = "";
        public void language(string lang)
        {
            lan = lang;
        }

        private void btn_Other_Click(object sender, EventArgs e)
        {
            this.Hide();
            Withdraw_2_Form fr = new Withdraw_2_Form();
            fr.receiveFinger(fingerPrintNum, check);
            fr.language(lan);
            fr.ShowDialog();
        }

        string fingerPrintNum = "";
        bool check = false;
        public void receiveFinger(string finger, bool checkAccount)
        {
            fingerPrintNum = finger;
            check = checkAccount;
        }
        bool checkCon = false;
        public void btn_Enter_Click(object sender, EventArgs e)
        {
            this.Hide();
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
                sql = $"Select CURRENTBALANCE from [ACCOUNT] WHERE FINGERPRINT = {fingerPrintNum}";
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    valueOfBalance = sqlDataReader.GetValue(0).ToString();
                }
                balance = (double.Parse(valueOfBalance));
                sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            accountClass.transaction transaction = new accountClass.transaction();
            if (radio50.Checked == true)
            {
                if (transaction.Withdraw(50.0, balance))
                {
                    PleaseWait_Form fr2 = new PleaseWait_Form();
                    fr2.ShowDialog();
                    //MessageBox.Show("Please Wait, Your Request is being executed");
                    Ask_For_Receipt_Form fr4 = new Ask_For_Receipt_Form();
                    fr4.receivingValue(50, "Withdraw");
                    fr4.receiveFinger(fingerPrintNum, check);
                    fr4.language(lan);
                    fr4.ShowDialog();
                }
                else
                {
                    TryAgen_Form fr3 = new TryAgen_Form();
                    fr3.ShowDialog();
                    //MessageBox.Show("You enterd amount greater than your balance,Please Try Again");
                }
            }




            else if (radio100.Checked == true)
            {

                if (transaction.Withdraw(100.0, balance))
                {
                    PleaseWait_Form fr2 = new PleaseWait_Form();
                    fr2.ShowDialog();
                    //MessageBox.Show("Please Wait, Your Request is being executed");
                    Ask_For_Receipt_Form fr4 = new Ask_For_Receipt_Form();
                    fr4.receivingValue(100, "Withdraw");
                    fr4.receiveFinger(fingerPrintNum, check);
                    fr4.language(lan);
                    fr4.ShowDialog();
                }
                else
                {
                    TryAgen_Form fr3 = new TryAgen_Form();
                    fr3.ShowDialog();
                    //MessageBox.Show("You enterd amount greater than your balance,Please Try Again");

                }
            }

            else if (radio200.Checked == true)
            {
                if (transaction.Withdraw(200.0, balance))
                {
                    PleaseWait_Form fr2 = new PleaseWait_Form();
                    fr2.ShowDialog();
                    //MessageBox.Show("Please Wait, Your Request is being executed");
                    Ask_For_Receipt_Form fr4 = new Ask_For_Receipt_Form();
                    fr4.receivingValue(200, "Withdraw");
                    fr4.receiveFinger(fingerPrintNum, check);
                    fr4.language(lan);
                    fr4.ShowDialog();
                }
                else
                {
                    TryAgen_Form fr3 = new TryAgen_Form();
                    fr3.ShowDialog();
                    //MessageBox.Show("You enterd amount greater than your balance,Please Try Again");
                }
            }
            else if (radio300.Checked == true)
            {
                if (transaction.Withdraw(300.0, balance))
                {
                    PleaseWait_Form fr2 = new PleaseWait_Form();
                    fr2.ShowDialog();
                    //MessageBox.Show("Please Wait, Your Request is being executed");
                    Ask_For_Receipt_Form fr4 = new Ask_For_Receipt_Form();
                    fr4.receivingValue(300, "Withdraw");
                    fr4.receiveFinger(fingerPrintNum, check);
                    fr4.language(lan);
                    fr4.ShowDialog();
                }
                else
                {
                    TryAgen_Form fr3 = new TryAgen_Form();
                    fr3.ShowDialog();
                    //MessageBox.Show("You enterd amount greater than your balance,Please Try Again");
                }
            }
            else if (radio400.Checked == true)
            {
                if (transaction.Withdraw(400.0, balance))
                {
                    PleaseWait_Form fr2 = new PleaseWait_Form();
                    fr2.ShowDialog();
                    //MessageBox.Show("Please Wait, Your Request is being executed");
                    Ask_For_Receipt_Form fr4 = new Ask_For_Receipt_Form();
                    fr4.receivingValue(400, "Withdraw");
                    fr4.receiveFinger(fingerPrintNum, check);
                    fr4.language(lan);
                    fr4.ShowDialog();
                }
                else
                {
                    TryAgen_Form fr3 = new TryAgen_Form();
                    fr3.ShowDialog();
                    //MessageBox.Show("You enterd amount greater than your balance,Please Try Again");
                }
            }
            else if (radio500.Checked == true)
            {
                if (transaction.Withdraw(500.0, balance))
                {
                    PleaseWait_Form fr2 = new PleaseWait_Form();
                    fr2.ShowDialog();
                    //MessageBox.Show("Please Wait, Your Request is being executed");
                    Ask_For_Receipt_Form fr4 = new Ask_For_Receipt_Form();
                    fr4.receivingValue(500, "Withdraw");
                    fr4.receiveFinger(fingerPrintNum, check);
                    fr4.language(lan);
                    fr4.ShowDialog();
                }
                else
                {
                    TryAgen_Form fr3 = new TryAgen_Form();
                    fr3.ShowDialog();
                    // MessageBox.Show("You enterd amount greater than your balance,Please Try Again");
                }
            }
            else if (radio1000.Checked == true)
            {
                if (transaction.Withdraw(1000.0, balance))
                {
                    PleaseWait_Form fr2 = new PleaseWait_Form();
                    fr2.ShowDialog();
                    //MessageBox.Show("Please Wait, Your Request is being executed");
                    Ask_For_Receipt_Form fr4 = new Ask_For_Receipt_Form();
                    fr4.receivingValue(1000, "Withdraw");
                    fr4.receiveFinger(fingerPrintNum, check);
                    fr4.language(lan);
                    fr4.ShowDialog();
                }
                else
                {
                    TryAgen_Form fr3 = new TryAgen_Form();
                    fr3.ShowDialog();
                    // MessageBox.Show("You enterd amount greater than your balance,Please Try Again");
                }
            }
            else
            {
                btn_Other_Click(sender, e);
            }
        }
        private void Withdraw_1_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
