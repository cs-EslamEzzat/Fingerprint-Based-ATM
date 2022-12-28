
namespace FingerPrint_Based_ATM.Forms
{
    partial class Receipt_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt_Form));
            this.lblname = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.lblnewbal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbldep = new System.Windows.Forms.Label();
            this.lblwith = new System.Windows.Forms.Label();
            this.lblbal = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTypeOfAccount = new System.Windows.Forms.Label();
            this.btn_Ok = new CustomControls.TControls.TButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            resources.ApplyResources(this.lblname, "lblname");
            this.lblname.Name = "lblname";
            // 
            // Label7
            // 
            resources.ApplyResources(this.Label7, "Label7");
            this.Label7.Name = "Label7";
            // 
            // lblnewbal
            // 
            resources.ApplyResources(this.lblnewbal, "lblnewbal");
            this.lblnewbal.Name = "lblnewbal";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lbldep
            // 
            resources.ApplyResources(this.lbldep, "lbldep");
            this.lbldep.Name = "lbldep";
            // 
            // lblwith
            // 
            resources.ApplyResources(this.lblwith, "lblwith");
            this.lblwith.Name = "lblwith";
            // 
            // lblbal
            // 
            resources.ApplyResources(this.lblbal, "lblbal");
            this.lblbal.Name = "lblbal";
            // 
            // lbldate
            // 
            resources.ApplyResources(this.lbldate, "lbldate");
            this.lbldate.Name = "lbldate";
            // 
            // Label5
            // 
            resources.ApplyResources(this.Label5, "Label5");
            this.Label5.Name = "Label5";
            // 
            // lblDeposit
            // 
            resources.ApplyResources(this.lblDeposit, "lblDeposit");
            this.lblDeposit.Name = "lblDeposit";
            // 
            // Label3
            // 
            resources.ApplyResources(this.Label3, "Label3");
            this.Label3.Name = "Label3";
            // 
            // Label2
            // 
            resources.ApplyResources(this.Label2, "Label2");
            this.Label2.Name = "Label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.Name = "lblTime";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // lblTypeOfAccount
            // 
            resources.ApplyResources(this.lblTypeOfAccount, "lblTypeOfAccount");
            this.lblTypeOfAccount.Name = "lblTypeOfAccount";
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.Color.White;
            this.btn_Ok.BackgroundColor = System.Drawing.Color.White;
            this.btn_Ok.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Ok.BorderRadius = 28;
            this.btn_Ok.BorderSize = 2;
            this.btn_Ok.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Ok, "btn_Ok");
            this.btn_Ok.ForeColor = System.Drawing.Color.Black;
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.TextColor = System.Drawing.Color.Black;
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Receipt_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTypeOfAccount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.lblnewbal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbldep);
            this.Controls.Add(this.lblwith);
            this.Controls.Add(this.lblbal);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Receipt_Form";
            this.Load += new System.EventHandler(this.Receipt_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.TControls.TButton btn_Ok;
        internal System.Windows.Forms.Label lblname;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label lblnewbal;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label lbldep;
        internal System.Windows.Forms.Label lblwith;
        internal System.Windows.Forms.Label lblbal;
        internal System.Windows.Forms.Label lbldate;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label lblDeposit;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblTime;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label lblTypeOfAccount;
    }
}