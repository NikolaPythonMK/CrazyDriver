using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyDriver
{
    public class UserLoginDTO
    {
        public string userEmail { get; set; }
        public string userPassword { get; set; }

        public UserLoginDTO(string userEmail, string userPassword)
        {
            this.userEmail = userEmail;
            this.userPassword = userPassword;
        }
    }
}
