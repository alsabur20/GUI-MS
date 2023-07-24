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
    public partial class StudentUI : Form
    {
        private User user;
        private Form activeForm = null;
        
        public StudentUI(User user)
        {
            this.user = user;
            InitializeComponent();
            BookDL.ReadBooksData();
        }
        private void StudentUI_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void issue_btn_Click(object sender, EventArgs e)
        {
            IssueBook issueBook = new IssueBook(this.user);
            openChildForm(issueBook);
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            SearchBook searchBook = new SearchBook();
            openChildForm(searchBook);
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            ViewBooks viewBooks = new ViewBooks();
            openChildForm(viewBooks);
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook=new ReturnBook(user);
            returnBook.HideSearchPanel();
            openChildForm(returnBook);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void name_btn_Click(object sender, EventArgs e)
        {
            MyAccount myAccount=new MyAccount(this.user);
            openChildForm(myAccount);
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm.Controls.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReturnBook myBooks = new ReturnBook(user);
            myBooks.label1.Text = "MY BOOKS";
            openChildForm(myBooks);
        }
    }
}
