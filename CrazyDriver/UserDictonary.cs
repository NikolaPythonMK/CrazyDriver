using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyDriver
{
    [Serializable]
    public static class UserDictonary
    {
        public static Dictionary<string, UserData> userDictonary { get; set; } = new Dictionary<string, UserData>();

        public static void addUserWithData(string userEmail, UserData userData)
        {
            userDictonary.Add(userEmail, userData);
        }

        public static UserData getUserData(string userEmail)
        {
            return userDictonary.GetValueOrDefault(userEmail);
        }
    }
}
