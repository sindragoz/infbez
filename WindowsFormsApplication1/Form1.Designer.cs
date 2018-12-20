namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.tb_q = new System.Windows.Forms.TextBox();
            this.tb_p = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_n_open = new System.Windows.Forms.Label();
            this.tb_e = new System.Windows.Forms.Label();
            this.tb_d = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_n_private = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tbDecodeOutputFle = new System.Windows.Forms.TextBox();
            this.tbEncodeOutputFle = new System.Windows.Forms.TextBox();
            this.tbDecodeInputFle = new System.Windows.Forms.TextBox();
            this.tbEncodeInputFle = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_q
            // 
            this.tb_q.Location = new System.Drawing.Point(67, 277);
            this.tb_q.Name = "tb_q";
            this.tb_q.Size = new System.Drawing.Size(169, 24);
            this.tb_q.TabIndex = 0;
            // 
            // tb_p
            // 
            this.tb_p.Location = new System.Drawing.Point(67, 233);
            this.tb_p.Name = "tb_p";
            this.tb_p.Size = new System.Drawing.Size(169, 24);
            this.tb_p.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(5, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Расшифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonDecipher_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(6, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Зашифровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_n_open);
            this.groupBox2.Controls.Add(this.tb_e);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(67, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 89);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Открытый ключ";
            // 
            // tb_n_open
            // 
            this.tb_n_open.AutoSize = true;
            this.tb_n_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_n_open.Location = new System.Drawing.Point(21, 59);
            this.tb_n_open.Name = "tb_n_open";
            this.tb_n_open.Size = new System.Drawing.Size(20, 18);
            this.tb_n_open.TabIndex = 0;
            this.tb_n_open.Text = "n:";
            // 
            // tb_e
            // 
            this.tb_e.AutoSize = true;
            this.tb_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_e.Location = new System.Drawing.Point(21, 32);
            this.tb_e.Name = "tb_e";
            this.tb_e.Size = new System.Drawing.Size(20, 18);
            this.tb_e.TabIndex = 0;
            this.tb_e.Text = "e:";
            // 
            // tb_d
            // 
            this.tb_d.AutoSize = true;
            this.tb_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_d.Location = new System.Drawing.Point(21, 30);
            this.tb_d.Name = "tb_d";
            this.tb_d.Size = new System.Drawing.Size(20, 18);
            this.tb_d.TabIndex = 0;
            this.tb_d.Text = "d:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_n_private);
            this.groupBox3.Controls.Add(this.tb_d);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(67, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 89);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Закрытый ключ";
            // 
            // tb_n_private
            // 
            this.tb_n_private.AutoSize = true;
            this.tb_n_private.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_n_private.Location = new System.Drawing.Point(21, 59);
            this.tb_n_private.Name = "tb_n_private";
            this.tb_n_private.Size = new System.Drawing.Size(20, 18);
            this.tb_n_private.TabIndex = 0;
            this.tb_n_private.Text = "n:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "p:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "q:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(67, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Получить ключи";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.tb_p);
            this.groupBox1.Controls.Add(this.tb_q);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 367);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ключи";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.tbDecodeOutputFle);
            this.groupBox4.Controls.Add(this.tbEncodeOutputFle);
            this.groupBox4.Controls.Add(this.tbDecodeInputFle);
            this.groupBox4.Controls.Add(this.tbEncodeInputFle);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(352, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(261, 359);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(228, 45);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(26, 20);
            this.button8.TabIndex = 4;
            this.button8.Text = "...";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(228, 250);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(26, 20);
            this.button7.TabIndex = 3;
            this.button7.Text = "...";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(228, 225);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(26, 20);
            this.button6.TabIndex = 3;
            this.button6.Text = "...";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(229, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 20);
            this.button4.TabIndex = 3;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbDecodeOutputFle
            // 
            this.tbDecodeOutputFle.Location = new System.Drawing.Point(5, 251);
            this.tbDecodeOutputFle.Name = "tbDecodeOutputFle";
            this.tbDecodeOutputFle.Size = new System.Drawing.Size(211, 20);
            this.tbDecodeOutputFle.TabIndex = 2;
            this.tbDecodeOutputFle.TextChanged += new System.EventHandler(this.tbDecodeOutputFle_TextChanged);
            // 
            // tbEncodeOutputFle
            // 
            this.tbEncodeOutputFle.Location = new System.Drawing.Point(6, 45);
            this.tbEncodeOutputFle.Name = "tbEncodeOutputFle";
            this.tbEncodeOutputFle.Size = new System.Drawing.Size(211, 20);
            this.tbEncodeOutputFle.TabIndex = 2;
            this.tbEncodeOutputFle.TextChanged += new System.EventHandler(this.tbEncodeOutputFle_TextChanged);
            // 
            // tbDecodeIntputFle
            // 
            this.tbDecodeInputFle.Location = new System.Drawing.Point(6, 225);
            this.tbDecodeInputFle.Name = "tbDecodeIntputFle";
            this.tbDecodeInputFle.Size = new System.Drawing.Size(210, 20);
            this.tbDecodeInputFle.TabIndex = 2;
            this.tbDecodeInputFle.TextChanged += new System.EventHandler(this.tbDecodeIntputFle_TextChanged);
            // 
            // tbEncodeInputFle
            // 
            this.tbEncodeInputFle.Location = new System.Drawing.Point(7, 19);
            this.tbEncodeInputFle.Name = "tbEncodeInputFle";
            this.tbEncodeInputFle.Size = new System.Drawing.Size(210, 20);
            this.tbEncodeInputFle.TabIndex = 2;
            this.tbEncodeInputFle.TextChanged += new System.EventHandler(this.tbEncodeInputFle_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 497);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_q;
        private System.Windows.Forms.TextBox tb_p;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label tb_n_private;
        private System.Windows.Forms.Label tb_e;
        private System.Windows.Forms.Label tb_n_open;
        private System.Windows.Forms.Label tb_d;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbEncodeOutputFle;
        private System.Windows.Forms.TextBox tbEncodeInputFle;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox tbDecodeOutputFle;
        private System.Windows.Forms.TextBox tbDecodeInputFle;
        private System.Windows.Forms.Button button8;
    }
}

