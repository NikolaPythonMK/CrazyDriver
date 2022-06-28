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
    public partial class Paused : Form
    {
        public UserData user { get; set; }
        public int scoreCounter { get; set; }
        public Paused(UserData user, int scoreCounter)
        {
            InitializeComponent();
            this.user = user;
            this.scoreCounter = scoreCounter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (user.userScore < scoreCounter)
            {
                user.userScore = scoreCounter;
            }

            user.userCoins += (int)(scoreCounter * 0.1);

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Paused_Load(object sender, EventArgs e)
        {
            this.Location = new Point((int)(this.Width / 1.7), this.Height / 2);
        }
    }
}
