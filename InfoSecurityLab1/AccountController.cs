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
        private string decryptedFileName = "DecryptedUsersFile.txt";
        private string encryptedFileName = "EncryptedUsersFile.txt";

        CryptographyController cc;
        public int LoggedUserId
        {
            get
            {
                return loggedUserId;
            }
        }
        public List<User> getUserList()
        {
            if (userList.Count != 0)
                return userList;

            return null;
        }

        public AccountController()
        {
            cc = new CryptographyController();
            decryptEncryptedFile();
            fillUserLiftFromDecryptedFile();



        }

        private void decryptEncryptedFile()
        {
            //File.Create(decryptedFileName);
            sw = File.CreateText(decryptedFileName);   

            string encryptedLine=cc.DecryptFile(Convert.FromBase64String(File.ReadAllText(encryptedFileName)));
            //sr.Close();
            sw.WriteLine(encryptedLine);            
            sw.Close();
        }

        private void fillUserLiftFromDecryptedFile()
        {
            sr = new StreamReader(decryptedFileName);

            string[] userLine;
            string tmpUserLine = "";
            while (!sr.EndOfStream)
            {
                tmpUserLine = sr.ReadLine();
                if (tmpUserLine != "")
                {
                    userLine = tmpUserLine.Split(';');
                    if (userLine[2] == "admin")
                        userList.Add(new User(userLine[0], userLine[1], User.roles.admin));
                    else
                        userList.Add(new User(userLine[0], userLine[1], User.roles.user, Convert.ToBoolean(userLine[3]), Convert.ToBoolean(userLine[4])));
                    if (userLine.Length == 4 || userLine.Length == 6)
                        userList[userList.Count - 1].setLastLoginTime(Convert.ToDateTime(userLine[userLine.Length - 1] + ""));
                }
            }
            sr.Close();
        }

        public void saveChanges()
        {
            try
            {
                string decryptedStr = File.ReadAllText(decryptedFileName);

                string encryptedStr = "";
                foreach (var usr in userList)
                    encryptedStr += usr.ToString().Replace(" ", "") + "\n";
                using (StreamWriter sw = File.CreateText(encryptedFileName))

                    sw.WriteLine(cc.EncryptFile(encryptedStr));

                File.Delete(decryptedFileName);
            }
            catch {
            }
        }

        public void addNewUser(User newUser)
        {
            newUser.changePass(cc.EncryptToSHA(newUser.Password));
            userList.Add(newUser);
        }

        public void editUser(int editedUserId, User newUser)
        {
            newUser.changePass(newUser.Password,cc.EncryptToSHA(newUser.Password));
            userList[editedUserId] = newUser;
        }
        public User tryLogIn(string login, string pass, bool repeat)
        {
            foreach (User usr in userList)
            {
                if (usr.Login == login && usr.Password == cc.EncryptToSHA(pass))
                {
                    loggedUserId = userList.IndexOf(usr);
                    if(usr.Blocked)
                        throw new Exception("You were blocked!");
                    return usr;
                }
            }
            loggedUserId = -1;
            if (repeat)
                throw new Exception("Passwords does not match!");
            throw new Exception("Wrong login or password!");
        }
    }
}
