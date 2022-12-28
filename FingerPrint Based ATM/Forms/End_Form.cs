using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerPrint_Based_ATM.Forms
{
    public partial class End_Form : Form
    {
        public string checkA = "";
        public End_Form()
        {
            InitializeComponent();
        }

        public void checkAccount(string check)
        {
            checkA = check;
        }

        string fingerPrintNum = "";
        bool check = false;
        public void receiveFinger(string finger, bool checkAccount)
        {
            fingerPrintNum = finger;
            check = checkAccount;
        }


        string lan = "";
        public void language(string lang)
        {
            lan = lang;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction_Form fr = new Transaction_Form();
            fr.receiveFinger(fingerPrintNum, check);
            fr.language(lan);
            fr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Language_Form fr = new Language_Form();
            fr.checkSerial(true);
            fr.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
