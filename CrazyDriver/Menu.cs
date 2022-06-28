using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyDriver
{
    public partial class Menu : Form
    {
        public static SoundPlayer menuMusic;
        public UserData userData { get; set; }
        public User users { get; set; }
        public bool close { get; set; }
        public int carCounter { get; set; }
        public Menu(UserData userData, User users)
        {
            InitializeComponent();
            this.userData = userData;
            this.users = users;
            carCounter = userData.userCars.Count();
            renderMainMenuLabels();
        }
        public void renderMainMenuLabels()
        {
            lblMoney.Text = string.Format("Money: {0}$", userData.userCoins.ToString());
            lbluser.Text = string.Format("User: {0}", userData.user.userName);
            lblbestscore.Text = string.Format("Best score: {0}", userData.userScore);
            carCounter = userData.userCars.Count();
        }
        private Bitmap getFormBackgroundImage()
        {
            Bitmap bmp = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(this.BackgroundImage,
                    new Rectangle(0, 0, bmp.Width, bmp.Height));
            }
            return bmp;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if(ControlsConfiguration.menuMusic == true)
            {
                menuMusic = new SoundPlayer(@"sounds\menu.wav");
                menuMusic.Play();
            }
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            this.BackgroundImage = getFormBackgroundImage();
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Game game = new Game(userData, users, (PlayerCar)userData.userCars.ElementAt(startCountingCars));
            game.ShowDialog();
            Close();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            DataTransfer.point = this.Location;
            settings.ShowDialog();     
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuMusic.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!DataTransfer.gamePlayed || DataTransfer.saved)
            {
                return;
            }
            FileStream stream = new FileStream(@"data.data", FileMode.Create);
            IFormatter formatter = new BinaryFormatter();
            SaveDictonary dictonary = new SaveDictonary();

            SaveData save = new SaveData(users, dictonary);
#pragma warning disable SYSLIB0011 // Type or member is obsolete
            formatter.Serialize(stream, save);
#pragma warning restore SYSLIB0011 // Type or member is obsolete
            button1.Text = "Saved!";
            DataTransfer.saved = true;
        }

        private void shopBtn_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop(userData);
            DialogResult result = shop.ShowDialog();

            if(result == DialogResult.OK)
            {
                userData = shop.userData;
                renderMainMenuLabels();
            }
            else
            {
                userData = shop.userData;
                renderMainMenuLabels();
            }
        }
        public int startCountingCars { get; set; } = 0;
        private void Menu_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(userData.userCars.ElementAt(startCountingCars).carModel, (Width / 2)-50, (Height / 2)-100, 100, 200);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            startCountingCars = (startCountingCars + 1) % carCounter;
            Invalidate();
        }
    }
}
