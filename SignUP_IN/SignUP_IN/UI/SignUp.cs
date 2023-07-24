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
using GLMS.BL;

namespace GLMS
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            UserDL.LoadUsersData();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            SignUP();
        }

        private void SignUP()
        {
            string name = Naam.Text;
            string grade = jamat.Text;
            string userName = username.Text;
            string pass = password.Text;
            string role = Role.Text;
            User temp;
            if (role == "Student" || role == "stident")
            {
                temp = new Student(name, userName, pass, int.Parse(grade));
            }
            else
            {
                temp = new Admin(name, userName, pass, true);

            }
            if (UserDL.GetUser(temp) == null)
            {
                UserDL.AddUser(temp);
                UserDL.WriteUsersData();
                MessageBox.Show("Student Signed Up Successfully");
            }
            else
            {
                MessageBox.Show("User Already Exists");
            }
        }


        private void Backbtn_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void Login()
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
