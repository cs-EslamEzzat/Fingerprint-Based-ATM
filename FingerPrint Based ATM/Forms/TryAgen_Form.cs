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
    public partial class TryAgen_Form : Form
    {
        public TryAgen_Form()
        {
            InitializeComponent();
        }
        string fingerPrintNum = "";
        bool check = false;
        public void receiveFinger(string finger, bool checkAccount)
        {
            fingerPrintNum = finger;
            check = checkAccount;
        }
        string Button = "";
        public void receiveForm(string button)
        {
            Button = button;
        }


        string lan = "";
        public void language(string lang)
        {
            lan = lang;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Button == "Withdraw")
            {
                this.Hide();
                Withdraw_2_Form withdraw_2_Form = new Withdraw_2_Form();
                withdraw_2_Form.receiveFinger(fingerPrintNum, check);
                withdraw_2_Form.language(lan);
                withdraw_2_Form.ShowDialog();
            }
            else if (Button == "Transfer")
            {
                this.Hide();
                Transfer_Form transfer_Form = new Transfer_Form();
                transfer_Form.receiveFinger(fingerPrintNum, check);
                transfer_Form.language(lan);
                transfer_Form.ShowDialog();
            }
        }
    }
}
