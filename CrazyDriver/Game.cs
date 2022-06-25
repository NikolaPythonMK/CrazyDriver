using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyDriver
{
    public partial class Game : Form
    {
        public Scene scene { get; set; }
        public Timer spawningCars;
        public Timer shortTimer;
        public Timer speedTimer;
        public int state;  //1->left, 2->right, 0->none
        public int spawningCarsCounter;
        public int scoreCounter;
        public static int scoreSeed = 1;
        public int carSpeedIncrease;
        public Game()
        {
            InitializeComponent();
            DoubleBuffered = true;
            scene = new Scene(this.Width, this.Height);
            spawningCars = new Timer();
            shortTimer = new Timer();
            speedTimer = new Timer();
            createTimer(spawningCars, new EventHandler(spawningCars_Tick), 2000);
            createTimer(speedTimer, new EventHandler(speedTimer_Tick), 6000);
            createTimer(shortTimer, new EventHandler(shortTimer_Tick), 30);
     
            state = 0;
            spawningCarsCounter = 0;
            scoreCounter = 0;
            carSpeedIncrease = 10;

            SoundPlayer music = new SoundPlayer(@"sounds\ingame_music.wav");
            music.Play();
            Invalidate();
        }

        private void createTimer(Timer timer, EventHandler e, int interval, bool enabled = true)
        {
            timer.Tick += e;
            timer.Interval = interval;
            timer.Enabled = enabled;
        }

        private void pauseTimers(bool pause)
        {
            if (pause)
            {
                spawningCars.Stop();
                speedTimer.Stop();
                shortTimer.Stop();
            }
            else
            {
                spawningCars.Start();
                speedTimer.Start();
                shortTimer.Start();
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            pauseButton.Location = new Point(this.Width - 100, 30);
        }

        private void Game_SizeChanged(object sender, EventArgs e)
        {
            scene = new Scene(this.Width, this.Height);
            Invalidate();
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Left))
            {
                state = 1;
            }
            else if (e.KeyCode.Equals(Keys.Right))
            {
                state = 2;
            }
            else
            {
                state = 0;
            }
        }
        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            state = 0;
        }

        public void shortTimer_Tick(object sender, EventArgs e)
        {
            if (scene.isHit())
            {
                state = 0;
                pauseTimers(true);
                Lose form = new Lose();              
                DialogResult res = form.ShowDialog();
                if(res.Equals(DialogResult.Yes))
                {
                    pauseTimers(false);
                    scene.cars.Clear();
                   
                }
                else
                {
                    Application.Exit();
                }
            }
            scene.move(state);
            scene.moveCars(carSpeedIncrease);
            scoreCounter += scoreSeed;
            scoreLabel.Text = "Score: " + scoreCounter;
            xStat.Text = "X: " + scene.X_Position;
            Invalidate();
        }

        public void spawningCars_Tick(object sender, EventArgs e)
        {
            if(spawningCarsCounter % 10 == 0 && spawningCars.Interval > 600)
            {
                spawningCars.Interval -= 300;
                if(scene.carsPerSpawn < Scene.maxCarsPerSpawn)
                {
                    scene.carsPerSpawn++;
                }
            }
            spawningCarsCounter++;
            scene.spawnBotCars();
            Invalidate();
        }

        public void speedTimer_Tick(object sender, EventArgs e)
        {
            scoreSeed++;
            carSpeedIncrease += 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pauseTimers(true);
            Paused form = new Paused();
            DialogResult res = form.ShowDialog();
            if (res.Equals(DialogResult.OK))
            {
                pauseTimers(false);
            }
            else
            {
                Application.Exit();
            }
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            scene.draw(e.Graphics);
        }
    }
}
