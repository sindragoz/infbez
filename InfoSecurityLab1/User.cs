using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InfoSecurityLab1
{
    public class User
    {
        CryptographyController cc;
        private bool blocked = false;
        public enum roles { user, admin }
        private bool passRestrictionsOn = false;
        private roles role;
        private string login;
        private string password;
        private DateTime lastLoginTime;
        Regex regPunct = new Regex(@".*[,.;:]+");
        Regex regNum = new Regex(@".*[0-9]+");
        Regex regMath = new Regex(@".*[=\+\-\*\/]+");
        public bool Blocked
        {
            get
            {
                return blocked;
            }

            set
            {
                if (role != roles.admin)
                    blocked = value;
            }
        }

        public bool PassRestrictionsOn
        {
            get
            {
                return passRestrictionsOn;
            }

            set
            {
                if (role != roles.admin)
                    passRestrictionsOn = value;
            }
        }

        internal roles Role
        {
            get
            {
                return role;
            }
        }

        public string Login
        {
            get
            {
                return login;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

        }

        public DateTime LastLoginTime
        {
            get
            {
                return lastLoginTime;
            }
        }


        public User(
            string login,
            string password,
            roles role,
            bool blocked,
            bool passRestrictionsOn)
        {
            cc = new CryptographyController();
            this.blocked = blocked;
            this.passRestrictionsOn = passRestrictionsOn;
            this.role = role;
            this.login = login;
            this.password = password;
        }

        public User(
            string login,
            string password,
            roles role
            )
        {
            this.role = role;
            this.login = login;
            this.password = password;
        }

        public User()
        {
        }

        public void setLastLoginTime(DateTime d)
        {
            lastLoginTime = d;
        }
        override
        public string ToString()
        {
            return login + "; " + password + "; " + role.ToString() + "; " + blocked + "; " + PassRestrictionsOn + "; " + lastLoginTime.ToShortDateString();
        }

        public bool changePass(string newPass)
        {
            if (PassRestrictionsOn)
                if (regMath.IsMatch(newPass) && regNum.IsMatch(newPass) && regPunct.IsMatch(newPass))
                {
                    password = newPass;
                    return true;
                }
                else
                   throw new Exception("New password is incorrect");
            else
            {
                password = newPass;
                return true;
            }

        }
        public bool changePass(string newPass, string encodedNewPass)
        {
            if (PassRestrictionsOn)
                if (regMath.IsMatch(newPass) && regNum.IsMatch(newPass) && regPunct.IsMatch(newPass))
                {
                    password = encodedNewPass;
                    return true;
                }
                else
                    throw new Exception("New password is incorrect");
            else
            {
                password = encodedNewPass;
                return true;
            }

        }
    }
}
