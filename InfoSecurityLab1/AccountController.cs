using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSecurityLab1
{
    public class AccountController
    {
        private StreamReader sr;
        private List<User> userList = new List<User>();
        private int loggedUserId = -1;
        StreamWriter sw;
        string fileName= "users.txt";
        public int LoggedUserId
        {
            get
            {
                return loggedUserId;
            }
        }
        public List<User> getUserList() {     
            if(userList.Count!=0)
             return userList;

            return null;
        }

        public AccountController()
        {
            sr = new StreamReader(fileName);
            
            string []userLine;
            while (!sr.EndOfStream)
            {
                userLine = sr.ReadLine().Split(';');
                if (userLine[2] == "admin")
                    userList.Add(new User(userLine[0], userLine[1], User.roles.admin));
                else
                    userList.Add(new User(userLine[0], userLine[1], User.roles.user, Convert.ToBoolean(userLine[3]), Convert.ToBoolean(userLine[4])));
                if (userLine.Length == 4 || userLine.Length == 6)
                    userList[userList.Count - 1].setLastLoginTime(Convert.ToDateTime(userLine[userLine.Length-1]+""));
            }
            sr.Close();
        }

        public void saveChanges()
        {
            sw = new StreamWriter(fileName, false);
            foreach (var usr in userList)
            {
                sw.WriteLine(usr.ToString().Replace(" ",""));
            }
            sw.Close();
        }

        public void addNewUser(User newUser) {
            userList.Add(newUser);
        }

        public void editUser(int editedUserId, User newUser)
        {
            userList[editedUserId] = newUser;
        }

        public User tryLogIn(string login, string pass,bool repeat)
        {
            foreach (User usr in userList)
                if (usr.Login == login && usr.Password == pass)
                {
                    loggedUserId = userList.IndexOf(usr);
                    return usr;
                }
            loggedUserId = -1;
            if (repeat)
                throw new Exception("Passwords does not match!");
            throw new Exception("Wrong login or password!");
        }
    }
}
