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
    public partial class ReturnBook : Form
    {
        private User user;
        public ReturnBook(User user)
        {
            this.user= user;
            InitializeComponent();
            DataBind();
        }
        private List<Book> IssuedBooks()
        {
            List<Book> issuedBooks = new List<Book>();
            if (this.user is Admin a)
            {
                issuedBooks.Clear();
                foreach (Book book in BookDL.Books)
                {
                    if (book.GetStatus())
                    {
                        issuedBooks.Add(book);
                    }
                }
            }
            else if(this.user is Student s)
            {
                issuedBooks.Clear();
                foreach (Book book in BookDL.Books)
                {
                    if (book.Issuer==s.Name)
                    {
                        issuedBooks.Add(book);
                    }
                }
            }
            return issuedBooks;
        }
        private void DataBind()
        {
            dG.DataSource = null;
            dG.DataSource = IssuedBooks();
            dG.Refresh();
        }
        private void Returnbook(DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            string bName = dG.Rows[index].Cells[2].Value.ToString();
            BookDL.ReturnBookFromString(bName).ReturnBook();
            BookDL.WriteBooksData();
        }
        private void dG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dG.NewRowIndex || e.RowIndex < 0)
                return;
            if (e.ColumnIndex == dG.Columns["Return"].Index)
            {
                Returnbook(e);
                DataBind();
                MessageBox.Show("Book Returned Successfully");
            }
        }
        public void HideSearchPanel()
        {
            searchPanel.Hide();
            dG.Dock= DockStyle.Fill;
        }
    }
}
