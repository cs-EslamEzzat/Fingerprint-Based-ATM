
namespace FingerPrint_Based_ATM.Forms
{
    partial class Transaction_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblaccno = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Transfer = new CustomControls.TControls.TButton();
            this.btn_Deposit = new CustomControls.TControls.TButton();
            this.btn_Balance = new CustomControls.TControls.TButton();
            this.btn_Withdraw = new CustomControls.TControls.TButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btn_Logout = new CustomControls.TControls.TButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Name = "panel1";
            // 
            // lblaccno
            // 
            resources.ApplyResources(this.lblaccno, "lblaccno");
            this.lblaccno.BackColor = System.Drawing.Color.Transparent;
            this.lblaccno.ForeColor = System.Drawing.Color.White;
            this.lblaccno.Name = "lblaccno";
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Name = "lblDate";
            // 
            // lblname
            // 
            resources.ApplyResources(this.lblname, "lblname");
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.ForeColor = System.Drawing.Color.White;
            this.lblname.Name = "lblname";
            // 
            // Label2
            // 
            resources.ApplyResources(this.Label2, "Label2");
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.ForeColor = System.Drawing.Color.Yellow;
            this.Label2.Name = "Label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Name = "label3";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_Transfer);
            this.panel2.Controls.Add(this.btn_Deposit);
            this.panel2.Controls.Add(this.btn_Balance);
            this.panel2.Controls.Add(this.btn_Withdraw);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btn_Transfer
            // 
            this.btn_Transfer.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Transfer.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.btn_Transfer.BorderColor = System.Drawing.Color.Navy;
            this.btn_Transfer.BorderRadius = 40;
            this.btn_Transfer.BorderSize = 0;
            this.btn_Transfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Transfer.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Transfer, "btn_Transfer");
            this.btn_Transfer.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_Transfer.Name = "btn_Transfer";
            this.btn_Transfer.TextColor = System.Drawing.SystemColors.Info;
            this.btn_Transfer.UseVisualStyleBackColor = false;
            this.btn_Transfer.Click += new System.EventHandler(this.btn_Transfer_Click);
            // 
            // btn_Deposit
            // 
            this.btn_Deposit.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Deposit.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.btn_Deposit.BorderColor = System.Drawing.Color.Navy;
            this.btn_Deposit.BorderRadius = 40;
            this.btn_Deposit.BorderSize = 0;
            this.btn_Deposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Deposit.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Deposit, "btn_Deposit");
            this.btn_Deposit.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_Deposit.Name = "btn_Deposit";
            this.btn_Deposit.TextColor = System.Drawing.SystemColors.Info;
            this.btn_Deposit.UseVisualStyleBackColor = false;
            this.btn_Deposit.Click += new System.EventHandler(this.btn_Deposit_Click);
            // 
            // btn_Balance
            // 
            this.btn_Balance.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Balance.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.btn_Balance.BorderColor = System.Drawing.Color.Navy;
            this.btn_Balance.BorderRadius = 40;
            this.btn_Balance.BorderSize = 0;
            this.btn_Balance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Balance.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Balance, "btn_Balance");
            this.btn_Balance.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_Balance.Name = "btn_Balance";
            this.btn_Balance.TextColor = System.Drawing.SystemColors.Info;
            this.btn_Balance.UseVisualStyleBackColor = false;
            this.btn_Balance.Click += new System.EventHandler(this.btn_Balance_Click);
            // 
            // btn_Withdraw
            // 
            this.btn_Withdraw.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Withdraw.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.btn_Withdraw.BorderColor = System.Drawing.Color.Navy;
            this.btn_Withdraw.BorderRadius = 40;
            this.btn_Withdraw.BorderSize = 0;
            this.btn_Withdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Withdraw.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Withdraw, "btn_Withdraw");
            this.btn_Withdraw.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_Withdraw.Name = "btn_Withdraw";
            this.btn_Withdraw.TextColor = System.Drawing.SystemColors.Info;
            this.btn_Withdraw.UseVisualStyleBackColor = false;
            this.btn_Withdraw.Click += new System.EventHandler(this.btn_Withdraw_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Name = "label5";
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Name = "lblTime";
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.DeepPink;
            this.btn_Logout.BackgroundColor = System.Drawing.Color.DeepPink;
            this.btn_Logout.BorderColor = System.Drawing.Color.Red;
            this.btn_Logout.BorderRadius = 25;
            this.btn_Logout.BorderSize = 0;
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Logout, "btn_Logout");
            this.btn_Logout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // Transaction_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FingerPrint_Based_ATM.Properties.Resources.background_copy;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblaccno);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transaction_Form";
            this.Load += new System.EventHandler(this.Transaction_Form_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private CustomControls.TControls.TButton btn_Logout;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label lblaccno;
        internal System.Windows.Forms.Label lblDate;
        internal System.Windows.Forms.Label lblname;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.TControls.TButton btn_Transfer;
        private CustomControls.TControls.TButton btn_Deposit;
        private CustomControls.TControls.TButton btn_Balance;
        private CustomControls.TControls.TButton btn_Withdraw;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label lblTime;
    }
}