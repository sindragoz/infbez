namespace InfoSecurityLab1
{
    partial class UserForm
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
            this.logintb = new System.Windows.Forms.TextBox();
            this.loginlbl = new System.Windows.Forms.Label();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.blockcb = new System.Windows.Forms.ComboBox();
            this.restrictcb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logintb
            // 
            this.logintb.Location = new System.Drawing.Point(12, 25);
            this.logintb.Name = "logintb";
            this.logintb.Size = new System.Drawing.Size(196, 20);
            this.logintb.TabIndex = 0;
            // 
            // loginlbl
            // 
            this.loginlbl.AutoSize = true;
            this.loginlbl.Location = new System.Drawing.Point(9, 9);
            this.loginlbl.Name = "loginlbl";
            this.loginlbl.Size = new System.Drawing.Size(33, 13);
            this.loginlbl.TabIndex = 1;
            this.loginlbl.Text = "Login";
            // 
            // passwordtb
            // 
            this.passwordtb.Location = new System.Drawing.Point(12, 74);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.Size = new System.Drawing.Size(196, 20);
            this.passwordtb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // blockcb
            // 
            this.blockcb.FormattingEnabled = true;
            this.blockcb.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.blockcb.Location = new System.Drawing.Point(21, 140);
            this.blockcb.Name = "blockcb";
            this.blockcb.Size = new System.Drawing.Size(50, 21);
            this.blockcb.TabIndex = 2;
            // 
            // restrictcb
            // 
            this.restrictcb.FormattingEnabled = true;
            this.restrictcb.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.restrictcb.Location = new System.Drawing.Point(138, 140);
            this.restrictcb.Name = "restrictcb";
            this.restrictcb.Size = new System.Drawing.Size(47, 21);
            this.restrictcb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Block";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Restrict password";
            // 
            // submitbtn
            // 
            this.submitbtn.Location = new System.Drawing.Point(70, 177);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(68, 23);
            this.submitbtn.TabIndex = 3;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 212);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.restrictcb);
            this.Controls.Add(this.blockcb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginlbl);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.logintb);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logintb;
        private System.Windows.Forms.Label loginlbl;
        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox blockcb;
        private System.Windows.Forms.ComboBox restrictcb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitbtn;
    }
}