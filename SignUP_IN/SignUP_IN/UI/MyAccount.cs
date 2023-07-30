using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GLMS.BL;
using GLMS.DL;

namespace GLMS.UI
{
    public partial class MyAccount : Form
    {
        private User user;
        public MyAccount(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void MyAccount_Load(object sender, EventArgs e)
        {
            uName.Text = this.user.GetName();
            userName.Text = this.user.GetUserName();
            uPassword.Text = this.user.GetPassword();
            uName.Enabled = false;
            userName.Enabled = false;
            uPassword.Enabled = false;
        }

        private void editNameLabel_Click(object sender, EventArgs e)
        {
            uName.Enabled = true;
        }

        private void editUsernameLabel_Click(object sender, EventArgs e)
        {
            userName.Enabled = true;
        }

        private void editPasswordLabel_Click(object sender, EventArgs e)
        {
            uPassword.Enabled = true;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (user is Admin a)
            {
                a.Name = uName.Text;
                a.Username = userName.Text;
                a.Password = uPassword.Text;
                UserDL.WriteUsersData();
                MessageBox.Show("User Editted Successfully");
                this.Hide();
            }
            else if (user is Student s)
            {
                s.Name = uName.Text;
                s.Username = userName.Text;
                s.Password = uPassword.Text;
                UserDL.WriteUsersData();
                MessageBox.Show("User Editted Successfully");
                this.Hide();
            }
        }
    }
}
