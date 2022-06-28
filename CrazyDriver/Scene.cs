using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace CrazyDriver
{
    [Serializable]
    public class Scene
    {
        private static Random random = new Random();
        public int width { get; set; }
        public int heigth { get; set; }
        public PlayerCar player { get; set; }
        public int X_Position { get; set; }
        public int Y_Position { get; set; }
        public int score { get; set; }
        public int carsPerSpawn { get; set; }
        public decimal carHorsePower { get; set; }
        public static int maxCarsPerSpawn = 4;

        public List<BotCar> cars;

        public Scene(int width, int height, PlayerCar car)
        {
            this.width = width;
            this.heigth = heigth;
            cars = new List<BotCar>();
            X_Position = width / 2;
            Y_Position = height - (Car.HEIGHT + Car.HEIGHT / 2);
            score = 0;
            carsPerSpawn = 1;
            //vo PlayerCar() ke se primaat propertinjata od DTO objektot (slika, horsepower)
            player = car;
            carHorsePower = car.horsePower;
        }

        public void draw(Graphics g)
        {
            g.DrawImage(player.carModel, X_Position, Y_Position, Car.WIDTH, Car.HEIGHT);
            foreach (BotCar car in cars)
            {
                g.DrawImage(car.carModel, car.X_Pos, car.Y_Pos, Car.WIDTH, Car.HEIGHT);
            }
        }

        public bool isHit()
        {
            Rectangle p = new Rectangle(X_Position, Y_Position, PlayerCar.WIDTH, PlayerCar.HEIGHT);
            for(int i = 0; i < cars.Count; i++)
            {
                if (X_Position < cars[i].X_Pos + Car.WIDTH &&
                    X_Position + Car.WIDTH > cars[i].X_Pos &&
                    Y_Position < cars[i].Y_Pos + Car.HEIGHT &&
                    Car.HEIGHT + Y_Position > cars[i].Y_Pos)
                {
                    cars[i].Y_Pos += 300;
                    return true;
                }
            }
            return false;
        }

        public void move(int state)
        {
            if (state == 1 && X_Position > 20)
            {
                X_Position -= (int)((decimal)0.5 * carHorsePower); //X_Position -= player.carModel.speed
            }
            if (state == 2 && X_Position < width - Car.WIDTH * 2)
            {
                X_Position += (int)((decimal)0.5 * carHorsePower); //Y_Position -= player.carModel.speed
            }
        }

        public void spawnBotCars()
        {
            for (int i = 0; i < carsPerSpawn; i++)
            {
                int X = random.Next(1, width - 120);
                int Y = random.Next(-1500, -200);
                string name = "regularCar" + random.Next(3, 14) + ".png";
                BotCar bot = new BotCar(@"images\" + name, 30, X, Y);
                bot.carModel.RotateFlip(RotateFlipType.RotateNoneFlipY);
                cars.Add(bot);
            }
        }

        public void moveCars(int speed)
        {
            cars.RemoveAll(car => car.Y_Pos - Car.HEIGHT > Y_Position);
            foreach (BotCar car in cars)
            {
                car.move(speed);
            }
        }
    }
}
