namespace InfoSecurityLab1
{
    partial class CabinetForm
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
            this.rolelbl = new System.Windows.Forms.Label();
            this.roleGb = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logintimevaluelbl = new System.Windows.Forms.Label();
            this.loginvaluelbl = new System.Windows.Forms.Label();
            this.idvaluelbl = new System.Windows.Forms.Label();
            this.idlbl = new System.Windows.Forms.Label();
            this.logintimelbl = new System.Windows.Forms.Label();
            this.loginlbl = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.userWorkingPanel = new System.Windows.Forms.Panel();
            this.edituserbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.userlb = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.roleGb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.userWorkingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rolelbl
            // 
            this.rolelbl.AutoSize = true;
            this.rolelbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rolelbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rolelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rolelbl.ForeColor = System.Drawing.Color.Green;
            this.rolelbl.Location = new System.Drawing.Point(6, 19);
            this.rolelbl.Margin = new System.Windows.Forms.Padding(3);
            this.rolelbl.Name = "rolelbl";
            this.rolelbl.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.rolelbl.Size = new System.Drawing.Size(82, 75);
            this.rolelbl.TabIndex = 0;
            this.rolelbl.Text = "A";
            // 
            // roleGb
            // 
            this.roleGb.Controls.Add(this.rolelbl);
            this.roleGb.Location = new System.Drawing.Point(6, 19);
            this.roleGb.Name = "roleGb";
            this.roleGb.Size = new System.Drawing.Size(95, 100);
            this.roleGb.TabIndex = 1;
            this.roleGb.TabStop = false;
            this.roleGb.Text = "Role";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.logintimevaluelbl);
            this.groupBox1.Controls.Add(this.loginvaluelbl);
            this.groupBox1.Controls.Add(this.idvaluelbl);
            this.groupBox1.Controls.Add(this.idlbl);
            this.groupBox1.Controls.Add(this.logintimelbl);
            this.groupBox1.Controls.Add(this.loginlbl);
            this.groupBox1.Controls.Add(this.roleGb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 152);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Information";
            // 
            // logintimevaluelbl
            // 
            this.logintimevaluelbl.AutoSize = true;
            this.logintimevaluelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logintimevaluelbl.Location = new System.Drawing.Point(213, 91);
            this.logintimevaluelbl.Name = "logintimevaluelbl";
            this.logintimevaluelbl.Size = new System.Drawing.Size(46, 18);
            this.logintimevaluelbl.TabIndex = 5;
            this.logintimevaluelbl.Text = "label1";
            // 
            // loginvaluelbl
            // 
            this.loginvaluelbl.AutoSize = true;
            this.loginvaluelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginvaluelbl.Location = new System.Drawing.Point(213, 62);
            this.loginvaluelbl.Name = "loginvaluelbl";
            this.loginvaluelbl.Size = new System.Drawing.Size(46, 18);
            this.loginvaluelbl.TabIndex = 5;
            this.loginvaluelbl.Text = "label1";
            // 
            // idvaluelbl
            // 
            this.idvaluelbl.AutoSize = true;
            this.idvaluelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idvaluelbl.Location = new System.Drawing.Point(213, 29);
            this.idvaluelbl.Name = "idvaluelbl";
            this.idvaluelbl.Size = new System.Drawing.Size(46, 18);
            this.idvaluelbl.TabIndex = 5;
            this.idvaluelbl.Text = "label1";
            // 
            // idlbl
            // 
            this.idlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idlbl.Location = new System.Drawing.Point(107, 29);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(82, 22);
            this.idlbl.TabIndex = 4;
            this.idlbl.Text = "User id:";
            this.idlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logintimelbl
            // 
            this.logintimelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logintimelbl.Location = new System.Drawing.Point(107, 91);
            this.logintimelbl.Name = "logintimelbl";
            this.logintimelbl.Size = new System.Drawing.Size(82, 19);
            this.logintimelbl.TabIndex = 3;
            this.logintimelbl.Text = "Login time:";
            this.logintimelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loginlbl
            // 
            this.loginlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginlbl.Location = new System.Drawing.Point(107, 61);
            this.loginlbl.Name = "loginlbl";
            this.loginlbl.Size = new System.Drawing.Size(82, 21);
            this.loginlbl.TabIndex = 2;
            this.loginlbl.Text = "User login:";
            this.loginlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(424, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Change password";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(424, 50);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // userWorkingPanel
            // 
            this.userWorkingPanel.Controls.Add(this.edituserbtn);
            this.userWorkingPanel.Controls.Add(this.addbtn);
            this.userWorkingPanel.Controls.Add(this.userlb);
            this.userWorkingPanel.Location = new System.Drawing.Point(12, 170);
            this.userWorkingPanel.Name = "userWorkingPanel";
            this.userWorkingPanel.Size = new System.Drawing.Size(523, 309);
            this.userWorkingPanel.TabIndex = 10;
            // 
            // edituserbtn
            // 
            this.edituserbtn.Location = new System.Drawing.Point(423, 39);
            this.edituserbtn.Name = "edituserbtn";
            this.edituserbtn.Size = new System.Drawing.Size(91, 23);
            this.edituserbtn.TabIndex = 10;
            this.edituserbtn.Text = "Edit user";
            this.edituserbtn.UseVisualStyleBackColor = true;
            this.edituserbtn.Click += new System.EventHandler(this.edituserbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(423, 10);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(91, 23);
            this.addbtn.TabIndex = 9;
            this.addbtn.Text = "Add new user";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // userlb
            // 
            this.userlb.FormattingEnabled = true;
            this.userlb.HorizontalScrollbar = true;
            this.userlb.Location = new System.Drawing.Point(6, 10);
            this.userlb.Name = "userlb";
            this.userlb.Size = new System.Drawing.Size(400, 290);
            this.userlb.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(505, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "i";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CabinetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userWorkingPanel);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Name = "CabinetForm";
            this.Text = "Cabinet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cabinet_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CabinetForm_FormClosed);
            this.Load += new System.EventHandler(this.Cabinet_Load);
            this.roleGb.ResumeLayout(false);
            this.roleGb.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.userWorkingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label rolelbl;
        private System.Windows.Forms.GroupBox roleGb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.Label logintimelbl;
        private System.Windows.Forms.Label loginlbl;
        private System.Windows.Forms.Label logintimevaluelbl;
        private System.Windows.Forms.Label loginvaluelbl;
        private System.Windows.Forms.Label idvaluelbl;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel userWorkingPanel;
        private System.Windows.Forms.Button edituserbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.ListBox userlb;
        private System.Windows.Forms.Button button1;
    }
}