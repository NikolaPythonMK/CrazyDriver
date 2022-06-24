using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyDriver
{
    public class BotCar : Car
    {
        public BotCar(string path, decimal horsePower) : base(path, horsePower)
        {
        }

        public void speedUp()
        {
            speed += 5;
        }
    }
}
