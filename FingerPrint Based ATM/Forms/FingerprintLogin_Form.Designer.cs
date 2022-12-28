
namespace FingerPrint_Based_ATM.Forms
{
    partial class FingerprintLogin_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FingerprintLogin_Form));
            this.fingerprint = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cancel = new CustomControls.TControls.TButton();
            this.btn_Enter = new CustomControls.TControls.TButton();
            ((System.ComponentModel.ISupportInitialize)(this.fingerprint)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fingerprint
            // 
            resources.ApplyResources(this.fingerprint, "fingerprint");
            this.fingerprint.BackColor = System.Drawing.SystemColors.Control;
            this.fingerprint.Name = "fingerprint";
            this.fingerprint.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Name = "label3";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_Cancel);
            this.panel1.Controls.Add(this.btn_Enter);
            this.panel1.Name = "panel1";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Red;
            this.btn_Cancel.BackgroundColor = System.Drawing.Color.Red;
            this.btn_Cancel.BorderColor = System.Drawing.Color.Red;
            this.btn_Cancel.BorderRadius = 25;
            this.btn_Cancel.BorderSize = 0;
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Cancel, "btn_Cancel");
            this.btn_Cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.TextColor = System.Drawing.Color.Black;
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Enter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Enter.BorderColor = System.Drawing.Color.Lime;
            this.btn_Enter.BorderRadius = 25;
            this.btn_Enter.BorderSize = 0;
            this.btn_Enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Enter.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Enter, "btn_Enter");
            this.btn_Enter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.bt_Enter_Click);
            // 
            // FingerprintLogin_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fingerprint);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FingerprintLogin_Form";
            this.Load += new System.EventHandler(this.FingerprintLogin_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fingerprint)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.TControls.TButton btn_Cancel;
        private CustomControls.TControls.TButton btn_Enter;
        private System.Windows.Forms.PictureBox fingerprint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}