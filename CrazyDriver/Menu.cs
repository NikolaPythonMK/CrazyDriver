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
    public partial class Menu : Form
    {
        public static SoundPlayer menuMusic;
        public UserData userData { get; set; }
        public Menu(UserData userData)
        {
            InitializeComponent();
            this.userData = userData;
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
            Game game = new Game();
            DialogResult res = game.ShowDialog();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            DataTransfer.point = this.Location;
            settings.ShowDialog();     
        }
    }
}
