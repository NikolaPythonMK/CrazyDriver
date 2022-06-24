using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyDriver
{
    public class Scene
    {
        public int width { get; set; }
        public int heigth { get; set; }
        public PlayerCar player { get; set; }
        public int score { get; set; }
        public List<BotCar> cars;

        public Scene(int width, int height)
        {
            this.width = width;
            this.heigth = heigth;
            cars = new List<BotCar>();
        }


    }
}
