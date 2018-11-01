using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoSecurityLab1
{
    public partial class ChangePassForm : Form
    {
        public string oldPass,newPass;
        private bool isCorrect = false;

        public bool IsCorrect
        {
            get
            {
                return isCorrect;
            }
        }

        public ChangePassForm()
        {
            InitializeComponent();
        }

        private void ChangePassForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(oldPass==textBox1.Text && textBox2.Text == textBox3.Text)
            {
                isCorrect = true;
                newPass = textBox2.Text;
                Close();
            }
        }
    }
}
