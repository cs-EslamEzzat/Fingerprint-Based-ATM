using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FingerPrint_Based_ATM.Database;
namespace FingerPrint_Based_ATM.Forms
{
    public partial class Check_AccounType_Form : Form
    {
        public Check_AccounType_Form()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 4;
            if (panel2.Width >= 720)
            {
                timer1.Stop();
                this.Hide();
            }
        }




        string lan = "";
        public void language(string lang)
        {
            lan = lang;
        }





        string acc = "";
        string fingerPrintNum = "";
        public void receiveFinger(string finger, string Account)
        {
            fingerPrintNum = finger;
            acc = Account;
        }





        private void Check_AccounType_Form_Load(object sender, EventArgs e)
        {

            accountType.Text = acc;

        }
    }
}
