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
    public partial class LoginForm : Form
    {
        AccountController acc;
        public LoginForm()
        {
            InitializeComponent();
        }
        private int loginTries = 0;
        private void loginBtn_Click(object sender, EventArgs e)
        {
            User user;
            CryptographyController cc = new CryptographyController();
            
            try
            {
                user=acc.tryLogIn(loginTb.Text, passTb.Text, !loginTb.Enabled);
                if (user.LastLoginTime.Year==1&&loginTb.Enabled)
                {
                    loginTb.Enabled = false;
                    passlbl.Text = "Enter password again";
                    passTb.Text = "";
                }              
                else
                {
                    user.setLastLoginTime(DateTime.Now);
                    CabinetForm cab = new CabinetForm();
                    cab.acc = acc;
                    cab.Show();
                    Hide();
                }                              
            }
            catch(Exception ex) {
                errlbl.Visible = true;
                errlbl.Text = ex.Message;
                loginTb.Enabled = true;
                passTb.Text = "";
                passlbl.Text = "Password";
                loginTries++;
                if(loginTries>=3)
                    Application.Exit();
                return;
            }
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            acc = new AccountController();
        }
    }
}
