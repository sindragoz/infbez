namespace InfoSecurityLab1
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginTb = new System.Windows.Forms.TextBox();
            this.passTb = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.loginlbl = new System.Windows.Forms.Label();
            this.passlbl = new System.Windows.Forms.Label();
            this.errlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginTb
            // 
            this.loginTb.Location = new System.Drawing.Point(77, 38);
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(184, 20);
            this.loginTb.TabIndex = 0;
            // 
            // passTb
            // 
            this.passTb.Location = new System.Drawing.Point(77, 94);
            this.passTb.Name = "passTb";
            this.passTb.PasswordChar = '*';
            this.passTb.Size = new System.Drawing.Size(184, 20);
            this.passTb.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(134, 140);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // loginlbl
            // 
            this.loginlbl.AutoSize = true;
            this.loginlbl.Location = new System.Drawing.Point(74, 22);
            this.loginlbl.Name = "loginlbl";
            this.loginlbl.Size = new System.Drawing.Size(33, 13);
            this.loginlbl.TabIndex = 3;
            this.loginlbl.Text = "Login";
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Location = new System.Drawing.Point(74, 78);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(53, 13);
            this.passlbl.TabIndex = 4;
            this.passlbl.Text = "Password";
            // 
            // errlbl
            // 
            this.errlbl.AutoSize = true;
            this.errlbl.ForeColor = System.Drawing.Color.Red;
            this.errlbl.Location = new System.Drawing.Point(102, 117);
            this.errlbl.Name = "errlbl";
            this.errlbl.Size = new System.Drawing.Size(127, 13);
            this.errlbl.TabIndex = 5;
            this.errlbl.Text = "Wrong login or password!";
            this.errlbl.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 190);
            this.Controls.Add(this.errlbl);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.loginlbl);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passTb);
            this.Controls.Add(this.loginTb);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTb;
        private System.Windows.Forms.TextBox passTb;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label loginlbl;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.Label errlbl;
    }
}

