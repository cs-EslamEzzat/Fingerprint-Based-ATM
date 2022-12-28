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
using System.Threading;
using System.IO;
using System.Data.SqlClient;
using FingerPrint_Based_ATM.Database;
namespace FingerPrint_Based_ATM.Forms
{
    public partial class FingerprintLogin_Form : Form
    {
        public string serverName = @"ESLAMEZZAT\SQLEXPRESS";
        public string databaseName = "Finger";
        public static SqlConnection sqlConnection;
        public static string connectionString = "";
        public FingerprintLogin_Form()
        {
            InitializeComponent();
            connectionString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Language_Form fr = new Language_Form();
            fr.checkSerial(true);
            fr.ShowDialog();
        }

        string lan = "";
        public void language(string lang)
        {
            lan = lang;
        }


        public static string checkFing(string x)
        {
            if (x.Contains("1"))
                return "1";
            else if (x.Contains("2"))
                return "2";
            else if (x.Contains("3"))
                return "3";
            return "Try Again";
        }
        bool check = false;
        private void bt_Enter_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                check = true;
                Connection connection = new Connection();
                connection.db_ConnectionToDatabase(false, sqlConnection);
            }
            try
            {
                PinCode_Form pinCode = new PinCode_Form();
                SqlCommand sqlCommand;
                SqlDataReader sqlDataReader;
                string sql = "", output = "";
                sql = @"Select FINGERPRINT from [USER]";
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                string a = _serialPort.ReadExisting();
                
                bool checkFinger = false;
                string finger = checkFing(a);
                if (finger == "Try Again")
                {
                    Erorr_Fingerprint_Form f1 = new Erorr_Fingerprint_Form();
                    f1.ShowDialog();
                }
                else
                {
                    while (sqlDataReader.Read())
                    {
                        output = sqlDataReader.GetValue(0).ToString();
                        if (output == finger)
                        {
                            checkFinger = true;
                            Operating_Load_Form f1 = new Operating_Load_Form();
                            f1.ShowDialog();
                            this.Hide();
                            pinCode.receiveFinger(finger);
                            pinCode.language(lan);
                            pinCode.ShowDialog();
                            break;
                        }
                    }
                    if (!(checkFinger))
                    {
                        Erorr_Fingerprint_Form f1 = new Erorr_Fingerprint_Form();
                        f1.ShowDialog();
                        //MessageBox.Show("Finger Not Identified, Try Again");
                    }
                }
                sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
        static SerialPort _serialPort;
        bool checkSeriall = false;
        public void checkSerial(bool check)
        {
            checkSeriall = check;
        }
        private void FingerprintLogin_Form_Load(object sender, EventArgs e)
        {
            if (checkSeriall == false)
            {
                try
                {
                    _serialPort = new SerialPort();
                    _serialPort.PortName = "COM3";//Set your board COM
                    _serialPort.BaudRate = 9600;
                    _serialPort.Open();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error opening/writing to serial port :: " + ex.Message, "Error!");
                }
                checkSeriall = true;
            }
        }
    }
}
