using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyDriver
{
    public class User
    {
        public Guid ID { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }
        public string userPassword { get; set; }
        public List<User> userList { get; set; }

        public User()
        {
            userList = new List<User>();
        }

        public void registerUser(UserRegisterDTO userToRegister)
        {
            var tmp = userList.Where(u => u.userEmail.Equals(userToRegister.userEmail)).FirstOrDefault();
            if(tmp == null)
            {
                User userToAdd = new User() { ID = new Guid(), userEmail = userToRegister.userEmail, userName = userToRegister.userName, userPassword = userToRegister.userPassword };
                userList.Add(userToAdd);
                UserDictonary.addUserWithData(userToRegister.userEmail, new UserData(userToAdd));
            }
            else
            {
                throw new Exception("The user with the same email exists!");
            }
        }

        public UserData loginUser(UserLoginDTO userToLogin)
        {
            var tmp = userList.Where(u => u.userEmail.Equals(userToLogin.userEmail)).FirstOrDefault();
            if (tmp != null)
            {
                if (!tmp.userPassword.Equals(userToLogin.userPassword))
                {
                    throw new Exception("Password is not correct!");
                }

                UserData userData = UserDictonary.getUserData(tmp.userEmail);
                if(userData != null)
                {
                    return userData;
                }
                else
                {
                    throw new Exception("UserData not set");
                }
            }
            else
            {
                throw new Exception("Email not found!");
            }
        }

        public bool checkEmail(string email)
        {
            var tmp = userList.Where(u => u.userEmail.Equals(email)).FirstOrDefault();
            if (tmp != null)
            {
                return true;
            }

            return false;
        }

        public bool checkUserName(string userName)
        {
            var tmp = userList.Where(u => u.userName.Equals(userName)).FirstOrDefault();
            if (tmp != null)
            {
                return true;
            }

            return false;
        }
    }
}
