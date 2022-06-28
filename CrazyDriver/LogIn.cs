using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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

                try
                {
                    FileStream s = new FileStream("data.data", FileMode.Open);
                    IFormatter f = new BinaryFormatter();

    #pragma warning disable SYSLIB0011 // Type or member is obsolete
                    SaveData tmp = (SaveData)f.Deserialize(s);
    #pragma warning restore SYSLIB0011 // Type or member is obsolete

                    if (tmp == null)
                    {
                        users = new User();
                    }
                    else
                    {
                        users = tmp.users;
                        UserDictonary.userDictonary = tmp.userDictonary.dictonaryToSave;
                    }
                 }
                 catch (Exception)
                 {
                    users = new User();
                 }
                
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

                    Hide();
                        Menu tma = new Menu(returnUserData, users);
                        tma.ShowDialog();
                    Close();
                }catch(Exception ex)
                {
                    lblException.Text = ex.Message;
                }
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = getFormBackgroundImage();
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
    }
}
