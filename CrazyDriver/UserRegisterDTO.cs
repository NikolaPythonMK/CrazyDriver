using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyDriver
{
    public class UserRegisterDTO
    {
        public string userName { get; set; }
        public string userEmail { get; set; }
        public string userPassword { get; set; }

        public UserRegisterDTO(string userName, string userEmail, string userPassword)
        {
            this.userName = userName;
            this.userEmail = userEmail;
            this.userPassword = userPassword;
        }
    }
}
