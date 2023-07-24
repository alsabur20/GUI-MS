using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GLMS.DL;

namespace GLMS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            UserDL.LoadUsersData();
        }
        private void login_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void Login()
        {
            Login login =new Login();
            login.Show();
            this.Hide();
            
        }
        private void SignUp()
        {
            SignUp signin = new SignUp();
            signin.Show();
            this.Hide();
        }
       
        private void Signup_Click(object sender, EventArgs e)
        {
            SignUp();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
