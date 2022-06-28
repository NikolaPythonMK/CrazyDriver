using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyDriver
{
    [Serializable]
    public class UserData
    {
        public User user { get; set; }
        public List<Car> userCars { get; set; }
        public decimal userCoins { get; set; }
        public int userScore { get; set; }

        public UserData(User user)
        {
            this.user = user;
            userCars = new List<Car>() ;
            userCoins = 0;
            userScore = 0;
        }
    }
}
