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
    public partial class CabinetForm : Form
    {
       public AccountController acc;
        private List<User> userList;
        private int userId;
        public CabinetForm()
        {
            InitializeComponent();
        }

        private void Cabinet_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void refreshList()
        {
            userList = acc.getUserList();
            userlb.Items.Clear();
            if (userList[userId].Role == User.roles.admin)
                foreach (var usr in userList)
                    userlb.Items.Add(usr);
        }
        private void Cabinet_Load(object sender, EventArgs e)
        {
            refreshList();
            userId = acc.LoggedUserId;
            rolelbl.ForeColor = userList[userId].Role == User.roles.admin ? Color.Green : Color.Blue;
            rolelbl.Text= userList[userId].Role == User.roles.admin ? "A" : "U";
            idvaluelbl.Text = ""+userId;
            loginvaluelbl.Text = userList[userId].Login;
            logintimevaluelbl.Text= userList[userId].LastLoginTime.ToShortDateString();
            
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            UserForm userF = new UserForm();
            userF.ShowDialog();
            if (userF.IsCorrect)
            {
                acc.addNewUser(userF.NewUser);
                refreshList();
            }
        }

        private void edituserbtn_Click(object sender, EventArgs e)
        {
            if ((userlb.SelectedItem as User).Role != User.roles.admin)
            {
                UserForm userF = new UserForm();
                userF.edit = true;
                userF.NewUser = userlb.SelectedItem as User;
                userF.EditId = userlb.SelectedIndex;
                userF.ShowDialog();
                if (userF.IsCorrect)
                {
                    acc.editUser(userF.EditId, userF.NewUser);
                    refreshList();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangePassForm passF = new ChangePassForm();
            passF.oldPass = userList[userId].Password;
            passF.ShowDialog();
            if (passF.IsCorrect)
            {
                userList[userId].changePass(passF.newPass);
                
                acc.editUser(userId,userList[userId]);
                MessageBox.Show(passF.newPass);
                refreshList();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            acc.saveChanges();
        }
    }
}
