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
    public partial class Lose : Form
    {
        public int moneyToContinue { get; set; }
        public bool canContinue { get; set; }
        public UserData user { get; set; }
        public Lose(UserData user, int currentScore)
        {
            InitializeComponent();
            moneyToContinue = currentScore * 40;
            scoreEl.Text = "Score: " + currentScore;
            bestEl.Text = "Best: " + user.userScore;
            continueForEl.Text = "Continue for " + moneyToContinue + "$?";
            this.user = user;
            if(user.userCoins >= moneyToContinue)
            {
                canContinue = true;
            }
            else
            {
                canContinue = false;
            }
            //InitializeComponent();
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            if (canContinue)
            {
                this.user.userCoins -= moneyToContinue;
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            else
            {
                yesBtn.BackColor = Color.Red;
                continueForEl.Text = "You don't have enough money!";
            }
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void Lose_Load(object sender, EventArgs e)
        {
            this.Location = new Point((int)(this.Width / 1.7), this.Height / 2);
        }
    }
}
