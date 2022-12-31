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
    public partial class CheckAccountNumberForm : Form
    {
        public CheckAccountNumberForm()
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
    }
}
