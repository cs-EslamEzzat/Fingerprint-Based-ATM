
namespace FingerPrint_Based_ATM.Forms
{
    partial class PinCode_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PinCode_Form));
            this.label3 = new System.Windows.Forms.Label();
            this.pinCode = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Enter = new CustomControls.TControls.TButton();
            this.btn_Clear = new CustomControls.TControls.TButton();
            this.btn_Cancel = new CustomControls.TControls.TButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Name = "label3";
            // 
            // pinCode
            // 
            resources.ApplyResources(this.pinCode, "pinCode");
            this.pinCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pinCode.Name = "pinCode";
            this.pinCode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.pinCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pinCode_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FingerPrint_Based_ATM.Properties.Resources.keybad;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::FingerPrint_Based_ATM.Properties.Resources.secrecy_icon;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_Enter);
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Controls.Add(this.btn_Cancel);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Enter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Enter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Enter.BorderRadius = 25;
            this.btn_Enter.BorderSize = 0;
            this.btn_Enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Enter.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Enter, "btn_Enter");
            this.btn_Enter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Yellow;
            this.btn_Clear.BackgroundColor = System.Drawing.Color.Yellow;
            this.btn_Clear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Clear.BorderRadius = 25;
            this.btn_Clear.BorderSize = 0;
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Clear, "btn_Clear");
            this.btn_Clear.ForeColor = System.Drawing.Color.Black;
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.TextColor = System.Drawing.Color.Black;
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Red;
            this.btn_Cancel.BackgroundColor = System.Drawing.Color.Red;
            this.btn_Cancel.BorderColor = System.Drawing.Color.Navy;
            this.btn_Cancel.BorderRadius = 25;
            this.btn_Cancel.BorderSize = 0;
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Cancel, "btn_Cancel");
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // PinCode_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::FingerPrint_Based_ATM.Properties.Resources.tarek2;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pinCode);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PinCode_Form";
            this.Load += new System.EventHandler(this.PinCode_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private CustomControls.TControls.TButton btn_Enter;
        private CustomControls.TControls.TButton btn_Clear;
        private CustomControls.TControls.TButton btn_Cancel;
        private System.Windows.Forms.TextBox pinCode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}