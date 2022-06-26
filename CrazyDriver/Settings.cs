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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
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

        private void Settings_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = getFormBackgroundImage();
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Location = DataTransfer.point;

            menuMusicEl.Checked = ControlsConfiguration.menuMusic;
            gameMusicEl.Checked = ControlsConfiguration.gameMusic;
            arrowsEl.Checked = ControlsConfiguration.arrowsControls;
            lettersEl.Checked = ControlsConfiguration.lettersControls;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            if (arrowsEl.Checked)
            {
                ControlsConfiguration.leftControl = Keys.Left;
                ControlsConfiguration.rightControl = Keys.Right;
                ControlsConfiguration.arrowsControls = true;
                ControlsConfiguration.lettersControls = false;
            }
            else
            {
                ControlsConfiguration.leftControl = Keys.A;
                ControlsConfiguration.rightControl = Keys.D;
                ControlsConfiguration.arrowsControls = false;
                ControlsConfiguration.lettersControls = true;
            }

            if (gameMusicEl.Checked)
            {
                ControlsConfiguration.gameMusic = true;
            }
            else
            {
                ControlsConfiguration.gameMusic = false;
            }

            if (menuMusicEl.Checked)
            {
                ControlsConfiguration.menuMusic = true;
                Menu.menuMusic.Play();
            }
            else
            {
                ControlsConfiguration.menuMusic = false;
                Menu.menuMusic.Stop();
            }
            this.Close();
        }
    }
}
