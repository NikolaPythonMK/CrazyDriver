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
    public partial class Main : Form
    {
        public UserData userData { get; set; }
        public Main(UserData userData)
        {
            InitializeComponent();
            this.userData = userData;
            label1.Text = userData.user.userName;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
