
namespace FingerPrint_Based_ATM.Forms
{
    partial class Withdraw_2_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Withdraw_2_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Home = new CustomControls.TControls.TButton();
            this.lblaccno = new System.Windows.Forms.Label();
            this.lbldatee = new System.Windows.Forms.Label();
            this.btn_Enter = new CustomControls.TControls.TButton();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Name = "label1";
            // 
            // btn_Home
            // 
            resources.ApplyResources(this.btn_Home, "btn_Home");
            this.btn_Home.BackColor = System.Drawing.Color.Red;
            this.btn_Home.BackgroundColor = System.Drawing.Color.Red;
            this.btn_Home.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Home.BorderRadius = 25;
            this.btn_Home.BorderSize = 0;
            this.btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.ForeColor = System.Drawing.Color.Black;
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.TextColor = System.Drawing.Color.Black;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // lblaccno
            // 
            resources.ApplyResources(this.lblaccno, "lblaccno");
            this.lblaccno.BackColor = System.Drawing.Color.Transparent;
            this.lblaccno.ForeColor = System.Drawing.Color.Yellow;
            this.lblaccno.Name = "lblaccno";
            // 
            // lbldatee
            // 
            resources.ApplyResources(this.lbldatee, "lbldatee");
            this.lbldatee.BackColor = System.Drawing.Color.Transparent;
            this.lbldatee.ForeColor = System.Drawing.Color.Yellow;
            this.lbldatee.Name = "lbldatee";
            // 
            // btn_Enter
            // 
            resources.ApplyResources(this.btn_Enter, "btn_Enter");
            this.btn_Enter.BackColor = System.Drawing.Color.Yellow;
            this.btn_Enter.BackgroundColor = System.Drawing.Color.Yellow;
            this.btn_Enter.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Enter.BorderRadius = 30;
            this.btn_Enter.BorderSize = 0;
            this.btn_Enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Enter.FlatAppearance.BorderSize = 0;
            this.btn_Enter.ForeColor = System.Drawing.Color.Black;
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.TextColor = System.Drawing.Color.Black;
            this.btn_Enter.UseVisualStyleBackColor = false;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // Label4
            // 
            resources.ApplyResources(this.Label4, "Label4");
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Name = "Label4";
            // 
            // Label3
            // 
            resources.ApplyResources(this.Label3, "Label3");
            this.Label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Name = "Label3";
            // 
            // txtAmount
            // 
            resources.ApplyResources(this.txtAmount, "txtAmount");
            this.txtAmount.Name = "txtAmount";
            // 
            // balanceLabel
            // 
            resources.ApplyResources(this.balanceLabel, "balanceLabel");
            this.balanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.balanceLabel.ForeColor = System.Drawing.Color.White;
            this.balanceLabel.Name = "balanceLabel";
            // 
            // dateLabel
            // 
            resources.ApplyResources(this.dateLabel, "dateLabel");
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Click += new System.EventHandler(this.dateLabel_Click);
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Name = "lblTime";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Name = "label2";
            // 
            // Withdraw_2_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FingerPrint_Based_ATM.Properties.Resources.ATMLogo;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.lblaccno);
            this.Controls.Add(this.lbldatee);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Withdraw_2_Form";
            this.Load += new System.EventHandler(this.Withdraw_2_Form_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CustomControls.TControls.TButton btn_Home;
        internal System.Windows.Forms.Label lblaccno;
        internal System.Windows.Forms.Label lbldatee;
        private CustomControls.TControls.TButton btn_Enter;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtAmount;
        internal System.Windows.Forms.Label balanceLabel;
        internal System.Windows.Forms.Label dateLabel;
        internal System.Windows.Forms.Label lblTime;
        internal System.Windows.Forms.Label label2;
    }
}