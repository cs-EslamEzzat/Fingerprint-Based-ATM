
namespace FingerPrint_Based_ATM.Forms
{
    partial class AccountType_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountType_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_current = new CustomControls.TControls.TButton();
            this.btn_credit = new CustomControls.TControls.TButton();
            this.btn_Saving = new CustomControls.TControls.TButton();
            this.btn_Logout = new CustomControls.TControls.TButton();
            this.panel1.SuspendLayout();
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
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_current);
            this.panel1.Controls.Add(this.btn_credit);
            this.panel1.Controls.Add(this.btn_Saving);
            this.panel1.Name = "panel1";
            // 
            // btn_current
            // 
            this.btn_current.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_current.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.btn_current.BorderColor = System.Drawing.Color.Red;
            this.btn_current.BorderRadius = 35;
            this.btn_current.BorderSize = 0;
            this.btn_current.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_current.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_current, "btn_current");
            this.btn_current.ForeColor = System.Drawing.Color.Black;
            this.btn_current.Name = "btn_current";
            this.btn_current.TextColor = System.Drawing.Color.Black;
            this.btn_current.UseVisualStyleBackColor = false;
            this.btn_current.Click += new System.EventHandler(this.btn_current_Click);
            // 
            // btn_credit
            // 
            this.btn_credit.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_credit.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.btn_credit.BorderColor = System.Drawing.Color.Yellow;
            this.btn_credit.BorderRadius = 35;
            this.btn_credit.BorderSize = 0;
            this.btn_credit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_credit.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_credit, "btn_credit");
            this.btn_credit.ForeColor = System.Drawing.Color.Black;
            this.btn_credit.Name = "btn_credit";
            this.btn_credit.TextColor = System.Drawing.Color.Black;
            this.btn_credit.UseVisualStyleBackColor = false;
            this.btn_credit.Click += new System.EventHandler(this.btn_credit_Click);
            // 
            // btn_Saving
            // 
            this.btn_Saving.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_Saving.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.btn_Saving.BorderColor = System.Drawing.Color.Lime;
            this.btn_Saving.BorderRadius = 35;
            this.btn_Saving.BorderSize = 0;
            this.btn_Saving.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Saving.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Saving, "btn_Saving");
            this.btn_Saving.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Saving.Name = "btn_Saving";
            this.btn_Saving.Tag = "";
            this.btn_Saving.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Saving.UseVisualStyleBackColor = false;
            this.btn_Saving.Click += new System.EventHandler(this.btn_Saving_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Red;
            this.btn_Logout.BackgroundColor = System.Drawing.Color.Red;
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
            // AccountType_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FingerPrint_Based_ATM.Properties.Resources.background;
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountType_Form";
            this.Load += new System.EventHandler(this.AccountType_Form_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.TControls.TButton btn_current;
        private CustomControls.TControls.TButton btn_credit;
        private CustomControls.TControls.TButton btn_Saving;
        private CustomControls.TControls.TButton btn_Logout;
    }
}