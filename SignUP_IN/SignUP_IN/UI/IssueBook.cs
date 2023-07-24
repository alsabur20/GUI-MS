using GLMS.BL;
using GLMS.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GLMS.UI
{
    public partial class IssueBook : Form
    {
        private User user;
        public IssueBook(User user)
        {
            this.user = user;
            InitializeComponent();
            dataBind(BookDL.Books);
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            List<Book> books = new List<Book>();
            if (bName.Text != null)
            {
                books = BookDL.SearchBook(bName.Text);
            }
            dataBind(books);
        }
        private void dataBind(List<Book> Books)
        {
            dG.DataSource = null;
            dG.DataSource = Books;
            dG.Refresh();
        }
        private void Issuebook(DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            string bname = dG.Rows[index].Cells[2].Value.ToString();
            BookDL.ReturnBookFromString(bname).IssueBook(this.user.Name);
        }
        private void dG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dG.NewRowIndex || e.RowIndex < 0)
                return;
            if (e.ColumnIndex == dG.Columns["Issue"].Index)
            {
                Issuebook(e);
                dataBind(BookDL.Books);
            }
        }
    }
}

