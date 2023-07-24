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
using GLMS.UI;

namespace GLMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            UserDL.LoadUsersData();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LogIn();
        }
        private void ClearDataFromForm()
        {
            username.Text = "";
            password.Text = "";
        }
        private void LogIn()
        {
            string userName = username.Text;
            string pass = password.Text;
            User temp = UserDL.GetUser(new User(userName, pass));
            if (temp is Student student)
            {
                /*MessageBox.Show("Student Logged In");*/
                StudentUI studentUI = new StudentUI(temp);
                studentUI.Show();
                this.Hide();
            }
            else if (temp is Admin admin)
            {
                /*MessageBox.Show("Admin Logged In");*/
                AdminUI adminUI = new AdminUI(temp);
                adminUI.Show();
                this.Hide();
            }
            else if (temp == null)
            {
                MessageBox.Show("User Does Not Exit");
            }
            ClearDataFromForm();
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Signup();
        }

        private void Signup()
        {
            SignUp signin = new SignUp();
            signin.Show();
            this.Hide();
        }

        private void username_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username.Text))
            {
                e.Cancel = true;
                username.Focus();
                errorProvider1.SetError(username, "Userame should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(username, "");
            }
        }

        private void password_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(password.Text))
            {
                e.Cancel = true;
                password.Focus();
                errorProvider1.SetError(password, "Password should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(password, "");
            }
        }

        private void username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
            }

        }
    }
}
