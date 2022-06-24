using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyDriver
{
    public partial class Register : Form
    {
        public User users { get; set; }
        public UserRegisterDTO register { get; set; }
        public Register(User users)
        {
            InitializeComponent();
            this.users = users;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

            if (users.checkEmail(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Email already exists!");
            }
            else if(!reg.IsMatch(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Field is not a valid email!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                if(string.IsNullOrEmpty(errorProvider1.GetError(txtEmail))  && string.IsNullOrEmpty(errorProvider1.GetError(txtUserName)))
                {
                    register = new UserRegisterDTO(txtUserName.Text, txtEmail.Text, txtPassword.Text);
                    DialogResult = DialogResult.OK;
                }
            }
           
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (users.checkEmail(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "UserName already exists!");
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }
        }
    }
}
