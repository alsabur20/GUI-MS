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
    public partial class EditBookSubForm : Form
    {
        private int bIndex;
        private Book book;
        public EditBookSubForm(Book book, int bIndex)
        {
            InitializeComponent();
            this.book = book;
            this.bIndex = bIndex;
        }

        private void EditBookSubForm_Load(object sender, EventArgs e)
        {
            bID.Text = this.book.BookID.ToString();
            bName.Text = this.book.BookName.ToString();
            bAuthor.Text = this.book.Author.ToString();
            bGenre.Text = this.book.Genre.ToString();
        }
        private void editBook_btn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(bID.Text);
            string name = bName.Text;
            string author = bAuthor.Text;
            string genre = bGenre.Text;
            Book nBook=new Book(id, name, author, genre);
            BookDL.DeleteBook(this.bIndex);
            BookDL.AddBook(nBook);
            this.Hide();
            EditBook obj = (EditBook)Application.OpenForms["EditBook"];
            obj.DataBind();
        }
    }
}
