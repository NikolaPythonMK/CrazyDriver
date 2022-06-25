using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyDriver
{
    public abstract class Car
    {
        public Bitmap carModel { get; set; }
        public static int WIDTH = 100;
        public static int HEIGHT = 200;
        public decimal horsePower { get; set; }

        public Car(String path, decimal horsePower)
        {
            this.carModel = new Bitmap(path);
            this.horsePower = horsePower;
        }
    }
}
