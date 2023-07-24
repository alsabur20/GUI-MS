using GLMS.DL;
using GLMS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Drawing.Imaging;

namespace GLMS.UI
{
    public partial class DeleteBook : Form
    {
        public DeleteBook()
        {
            InitializeComponent();
            dataBind(BookDL.Books);
        }
        private void dataBind(List<Book> Books)
        {
            dG.DataSource = null;
            dG.DataSource = Books;
            dG.Refresh();
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
        private int Deletebook(DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            string bname= dG.Rows[index].Cells[2].Value.ToString();
            return BookDL.ReturnBookIndex(bname);
        }
        private void dG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex == dG.NewRowIndex || e.RowIndex < 0)
                return;
            if (e.ColumnIndex == dG.Columns["Delete"].Index)
            {
                BookDL.DeleteBook(Deletebook(e));
                dataBind(BookDL.Books);
            }
            

        }
    }
}
