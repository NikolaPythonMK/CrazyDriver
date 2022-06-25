using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyDriver
{
    public class PlayerCar : Car
    {
        public decimal health { get; set; }
        public decimal speed { get; set; }
        public PlayerCar(string path, decimal horsePower) : base(path, horsePower)
        {
            speed = horsePower * (decimal)0.48;
        }
    }
}
