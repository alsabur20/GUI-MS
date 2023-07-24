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

namespace GLMS.UI
{
    public partial class AdminUI : Form
    {
        private User User;
        public AdminUI(User user)
        {
            this.User = user;
            InitializeComponent();
            BookDL.ReadBooksData();
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void view_btn_Click(object sender, EventArgs e)
        {
            ViewBooks viewBooks = new ViewBooks();
            openChildForm(viewBooks);
            //viewBooks.Show();
            //this.Hide();
        }
        private Form activeForm = null;
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

        private void home_btn_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm.Controls.Clear();
        }

        private void AdminUI_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            openChildForm(addBook);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DeleteBook deleteBook = new DeleteBook();
            openChildForm(deleteBook);
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            SearchBook searchBook = new SearchBook();
            openChildForm(searchBook);
        }

        private void viewissued_btn_Click(object sender, EventArgs e)
        {
            VIssuedBooks vIssuedBooks = new VIssuedBooks();
            openChildForm(vIssuedBooks);
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            EditBook editBook = new EditBook();
            openChildForm(editBook);
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook(User);
            openChildForm(returnBook);
        }

        private void viewStudents_btn_Click(object sender, EventArgs e)
        {
            ViewStudents viewStudents = new ViewStudents();
            openChildForm(viewStudents);
        }

        private void logout_btn_Click_1(object sender, EventArgs e)
        {

            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void name_btn_Click(object sender, EventArgs e)
        {
            MyAccount myAccount = new MyAccount(this.User);
            openChildForm(myAccount);
        }
    }
}
