using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyDriver
{
    public class PlayerCar : Car
    {
        public decimal health { get; set; }
        public PlayerCar(string path, decimal horsePower, decimal health) : base(path, horsePower)
        {
            this.health = health;
        }

        public bool carCrash(decimal damage)
        {
            if(health - damage <= 0)
            {
                return false;
            }
            else
            {
                health -= damage;
                return true;
            }
        }
        //TODO: drawPlayerCar(), isHit(), move(), spawnBotCar(), 

        public void drawPlayerCar()
        {

        }

        public void isHit()
        {

        }

        public void move()
        {

        }

        public void spawnBotCar()
        {

        }

    }
}
