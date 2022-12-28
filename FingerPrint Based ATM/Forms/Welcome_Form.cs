using FingerPrint_Based_ATM.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerPrint_Based_ATM
{
    public partial class wellcome_Form : Form
    {
        public wellcome_Form()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >=720)
            {
                timer1.Stop();
                Language_Form fr = new Language_Form();
                fr.Show();
                this.Hide();
            }
        }

        private void wellcome_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
