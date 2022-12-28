
namespace FingerPrint_Based_ATM.Forms
{
    partial class Balance_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balance_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Home = new CustomControls.TControls.TButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_accountno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Enter = new CustomControls.TControls.TButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Home);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Name = "label1";
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.Red;
            this.btn_Home.BackgroundColor = System.Drawing.Color.Red;
            this.btn_Home.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Home.BorderRadius = 28;
            this.btn_Home.BorderSize = 0;
            this.btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Home, "btn_Home");
            this.btn_Home.ForeColor = System.Drawing.Color.Black;
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.TextColor = System.Drawing.Color.Black;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.lbl_amount);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbl_accountno);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbl_username);
            this.panel2.Controls.Add(this.label5);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // lbl_amount
            // 
            resources.ApplyResources(this.lbl_amount, "lbl_amount");
            this.lbl_amount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_amount.ForeColor = System.Drawing.Color.White;
            this.lbl_amount.Name = "lbl_amount";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Name = "label6";
            // 
            // lbl_accountno
            // 
            resources.ApplyResources(this.lbl_accountno, "lbl_accountno");
            this.lbl_accountno.BackColor = System.Drawing.Color.Transparent;
            this.lbl_accountno.ForeColor = System.Drawing.Color.White;
            this.lbl_accountno.Name = "lbl_accountno";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // lbl_username
            // 
            resources.ApplyResources(this.lbl_username, "lbl_username");
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Name = "lbl_username";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Name = "label5";
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.Yellow;
            this.btn_Enter.BackgroundColor = System.Drawing.Color.Yellow;
            this.btn_Enter.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Enter.BorderRadius = 30;
            this.btn_Enter.BorderSize = 0;
            this.btn_Enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Enter.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Enter, "btn_Enter");
            this.btn_Enter.ForeColor = System.Drawing.Color.Black;
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.TextColor = System.Drawing.Color.Black;
            this.btn_Enter.UseVisualStyleBackColor = false;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // Balance_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FingerPrint_Based_ATM.Properties.Resources.ATMLogo;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Balance_Form";
            this.Load += new System.EventHandler(this.Balance_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CustomControls.TControls.TButton btn_Home;
        private CustomControls.TControls.TButton btn_Enter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_accountno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label label5;
    }
}