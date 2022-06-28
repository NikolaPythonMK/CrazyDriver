using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyDriver
{
    [Serializable]
    public class BotCar : Car
    {
        public int X_Pos { get; set; }
        public int Y_Pos { get; set; }
        public BotCar(string path, decimal horsePower, int X, int Y) : base(path, horsePower)
        {
            X_Pos = X;
            Y_Pos = Y;
        }

        public void move(int speed)
        {
            Y_Pos += speed;
        }
    }
}
