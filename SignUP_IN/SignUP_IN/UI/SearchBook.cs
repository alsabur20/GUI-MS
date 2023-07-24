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
    public partial class SearchBook : Form
    {
        public SearchBook()
        {
            InitializeComponent();
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
    }
}
