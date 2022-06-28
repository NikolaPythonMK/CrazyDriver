using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyDriver
{
    [Serializable]
    public class PlayerCar : Car
    {
        public decimal health { get; set; }
        public decimal speed { get; set; }
        public decimal price { get; set; }
        public PlayerCar(string path, decimal horsePower, decimal price) : base(path, horsePower)
        {
            speed = horsePower * (decimal)0.48;
            this.price = price;
        }
    }
}
