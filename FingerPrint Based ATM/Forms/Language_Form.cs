using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerPrint_Based_ATM.Forms
{
    public partial class Language_Form : Form
    {
        public Language_Form()
        {
            InitializeComponent();
        }
        bool checkS = false;
        public void checkSerial(bool check)
        {
            checkS = check;
        }
        private void language_Form_Load(object sender, EventArgs e)
        {

        }

        private void tButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // If the user will use the Arabic language
        private void btn_ArEg_Click(object sender, EventArgs e)
        {
            this.Hide();
            string lang = "ar-EG";
            CultureInfo culInfo = new CultureInfo(lang, true);
            Thread.CurrentThread.CurrentCulture = culInfo;
            Thread.CurrentThread.CurrentUICulture = culInfo;
            FingerprintLogin_Form fr = new FingerprintLogin_Form();
            fr.checkSerial(checkS);
            fr.language(lang);
            fr.ShowDialog();
        }
        // If the user will use the English language
        private void btn_En_Click(object sender, EventArgs e)
        {
            this.Hide();
            string lang = "en";
            CultureInfo culInfo = new CultureInfo(lang, true);
            Thread.CurrentThread.CurrentCulture = culInfo;
            Thread.CurrentThread.CurrentUICulture = culInfo;
            FingerprintLogin_Form fr = new FingerprintLogin_Form();
            fr.checkSerial(checkS);
            fr.language(lang);
            fr.ShowDialog();
        }
    }
}
