using GLMS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GLMS.UI
{
    public partial class ChangePassword : Form
    {
        private User user;
        public ChangePassword(User user)
        {
            this.user = user;
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if(p1.Text==this.user.Password)
            {
                if (p2.Text == p3.Text)
                {
                    this.user.Password = p3.Text;
                    MessageBox.Show("Password changed successfully");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Passwords do not match");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Old Password");
            }
        }

        private void ChangePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
