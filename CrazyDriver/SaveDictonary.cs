using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyDriver
{
    [Serializable]
    public class SaveDictonary
    {
        public Dictionary<string, UserData> dictonaryToSave { get; set; }

        public SaveDictonary()
        {
            dictonaryToSave = new Dictionary<string, UserData>();

            for(int i = 0; i < UserDictonary.userDictonary.Count(); i++)
            {
                dictonaryToSave.Add(UserDictonary.userDictonary.ElementAt(i).Key, UserDictonary.userDictonary.ElementAt(i).Value);
            }
        }
    }
}
