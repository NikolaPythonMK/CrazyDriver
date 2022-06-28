using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyDriver
{
    [Serializable]
    public class SaveData
    {
        public User users { get; set; }
        public SaveDictonary userDictonary { get; set; }

        public SaveData(User users, SaveDictonary dictonary)
        {
            this.users = users;
            userDictonary = dictonary;
        }
    }
}
