using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyDriver
{
    public partial class Shop : Form
    {
        public List<Car> cars { get; set; }
        public UserData userData { get; set; }
        public Shop(UserData userData)
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.userData = userData;
            cars = new List<Car>();
            cars.Add(new PlayerCar("images/sportsCar1.png", 10 , 50000));
            cars.Add(new PlayerCar("images/sportsCar2.png", 30, 100000));
            cars.Add(new PlayerCar("images/sportsCar3.png", 60, 150000));
            cars.Add(new PlayerCar("images/sportsCar4.png", 90, 200000));
            cars.Add(new PlayerCar("images/sportsCar5.png", 110, 250000));
            lblMoney.Text = String.Format("Money: {0}$", userData.userCoins);
        }

        private void Shop_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e, string price, PlayerCar car)
        {
            if(userData.userCoins >= Convert.ToInt32(price))
            {
                userData.userCoins -= Convert.ToInt32(price);
                userData.userCars.Add(car);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("You`re broke hehe xD");
            }
        }

        private void Shop_Paint(object sender, PaintEventArgs e)
        {
            int x = 20;
            int y = 20;
            foreach (PlayerCar c in cars)
            {
                if(userData.userCars.Where(s => s.path.Equals(c.path)).FirstOrDefault() == null){
                        e.Graphics.DrawImage(c.carModel, x, y, Car.WIDTH, Car.HEIGHT);
                        e.Graphics.DrawString(c.price.ToString(), new Font("Arial", 15), new SolidBrush(Color.Black), new Point(x + 10, y + 210));

                        Button btn1 = new Button();

                        btn1.Text = "BUY";
                        btn1.Name = c.price.ToString();
                        btn1.Visible = true;
                        btn1.Location = new Point(x + 10, y + 240);
                        btn1.Click += (sender, EventArgs) => { Button_Click(sender, EventArgs, btn1.Name, c); };

                        Controls.Add(btn1);

                        x += 150;
                        if (x > 660)
                        {
                            y += 220;
                            x = 20;
                        }
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
