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
    public partial class UserForm : Form
    {
        public bool edit = false;
        private int editId = -1;

        private bool isCorrect = false;
        public bool IsCorrect
        {
            get
            {
                return isCorrect;
            }
        }
        private User newUser;

        public User NewUser
        {
            get
            {
                return newUser;
            }
            set
            {
                newUser = value;
            }
        }

        public int EditId
        {
            get
            {
                return editId;
            }

            set
            {
                editId = editId == -1 ? value : editId;
            }
        }

        public UserForm()
        {
            InitializeComponent();
        }



        private void UserForm_Load(object sender, EventArgs e)
        {
            if (edit)
            {
                logintb.Text = newUser.Login;
                passwordtb.Text = newUser.Password;
                blockcb.SelectedItem = newUser.Blocked ? blockcb.Items[0] : blockcb.Items[1];
                restrictcb.SelectedItem = newUser.PassRestrictionsOn ? blockcb.Items[0] : blockcb.Items[1];
            }
            else
            {
                blockcb.SelectedItem = blockcb.Items[1];
                restrictcb.SelectedItem = blockcb.Items[1];
            }
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (logintb.Text != "admin" && passwordtb.Text != "")
            {
                isCorrect = true;
                DateTime lastLoginTime = new DateTime();
                try
                {
                    lastLoginTime = newUser.LastLoginTime;
                }catch
                {

                }
                newUser = new User(logintb.Text, passwordtb.Text, User.roles.user, blockcb.SelectedIndex == 0, restrictcb.SelectedIndex == 0);
                newUser.setLastLoginTime(lastLoginTime);
            }
            Close();
        }
    }
}
