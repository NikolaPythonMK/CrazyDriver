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
    public partial class LogIn : Form
    {
        public User users { get; set; }
        public LogIn()
        {
            InitializeComponent();
            users = new User();
        }

        private void lblRegisterHere_Click(object sender, EventArgs e)
        {
            Register registerUser = new Register(users);
            if(registerUser.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    users.registerUser(registerUser.register);
                }catch(Exception ex)
                {
                    lblException.Text = ex.Message;
                }
                
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblException.Text = "";
            if(!string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                UserLoginDTO userLogin = new UserLoginDTO(txtEmail.Text, txtPassword.Text);

                try
                {
                    UserData returnUserData = users.loginUser(userLogin);
                    Main tma = new Main(returnUserData);
                    tma.Show();
                }catch(Exception ex)
                {
                    lblException.Text = ex.Message;
                }
            }
        }
    }
}
