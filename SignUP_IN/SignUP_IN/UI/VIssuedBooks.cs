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
    public partial class VIssuedBooks : Form
    {
        public VIssuedBooks()
        {
            InitializeComponent();
            dataBind();
        }
        private void dataBind()
        {
            List<Book> books = new List<Book>();
            dG.DataSource = null;
            foreach (Book i in BookDL.Books)
            {
                if (i.GetStatus())
                {
                    books.Add(i);
                }
            }
            dG.DataSource = books;
            dG.Refresh();
        }
    }
}
