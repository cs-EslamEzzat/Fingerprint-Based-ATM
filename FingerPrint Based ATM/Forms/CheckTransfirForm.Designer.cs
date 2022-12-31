
namespace FingerPrint_Based_ATM.Forms
{
    partial class CheckTransfirForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckTransfirForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTransfer = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.btn_OK = new CustomControls.TControls.TButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lblTransfer
            // 
            resources.ApplyResources(this.lblTransfer, "lblTransfer");
            this.lblTransfer.Name = "lblTransfer";
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.Name = "lblTime";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.Name = "lblDate";
            // 
            // Label5
            // 
            resources.ApplyResources(this.Label5, "Label5");
            this.Label5.Name = "Label5";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // lblAccount
            // 
            resources.ApplyResources(this.lblAccount, "lblAccount");
            this.lblAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblAccount.ForeColor = System.Drawing.Color.Black;
            this.lblAccount.Name = "lblAccount";
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.LightCyan;
            this.btn_OK.BackgroundColor = System.Drawing.Color.LightCyan;
            this.btn_OK.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_OK.BorderRadius = 20;
            this.btn_OK.BorderSize = 2;
            this.btn_OK.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_OK, "btn_OK");
            this.btn_OK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // ChkTransfirForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTransfer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChkTransfirForm";
            this.Load += new System.EventHandler(this.ChkTransfirForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTransfer;
        internal System.Windows.Forms.Label lblTime;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label lblDate;
        internal System.Windows.Forms.Label Label5;
        private CustomControls.TControls.TButton btn_OK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAccount;
    }
}