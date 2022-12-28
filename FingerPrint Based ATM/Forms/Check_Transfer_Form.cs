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
    public partial class Chek_Transfer_Form : Form
    {
        public string checkA = "";
        public string serverName = @"ESLAMEZZAT\SQLEXPRESS";
        public string databaseName = "Finger";
        public static SqlConnection sqlConnection;
        public static string connectionString = "";
        public Chek_Transfer_Form()
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


        bool checkCon = false;
        private void Chek_Transfer_Form_Load(object sender, EventArgs e)
        {
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
                if (lan == "en")
                {
                    sql = $"Select NAME from [ACCOUNT] WHERE ACCOUNTNUMBER = {accountNum}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        accountOwner.Text = sqlDataReader.GetValue(0).ToString();
                    }
                    sqlDataReader.Close();
                }
                else
                {
                    sql = $"Select NAMEARABIC from [ACCOUNT] WHERE ACCOUNTNUMBER = {accountNum}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        accountOwner.Text = sqlDataReader.GetValue(0).ToString();
                    }
                    sqlDataReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ask_For_Receipt_Form fr = new Ask_For_Receipt_Form();
            fr.receiveFinger(fingerPrintNum, check);
            fr.receiveAccountNum(accountNum);
            fr.receivingValue(value, "Transfer");
            fr.language(lan);
            fr.ShowDialog();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfer_Form transfer_Form = new Transfer_Form();
            transfer_Form.receiveFinger(fingerPrintNum, check);
            transfer_Form.language(lan);
            transfer_Form.ShowDialog();
        }
    }
}
