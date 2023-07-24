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
    public partial class EditBook : Form
    {
        public EditBook()
        {
            InitializeComponent();
            DataBind();
        }
        public void DataBind()
        {
            dG.DataSource = null;
            dG.DataSource = BookDL.Books;
            dG.Refresh();
        }
        private void Editbook(DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            string bname = dG.Rows[index].Cells[2].Value.ToString();
            int bIndex= BookDL.ReturnBookIndex(bname);
            EditBookSubForm editBookSubForm = new EditBookSubForm(BookDL.ReturnBookFromString(bname), bIndex);
            editBookSubForm.Show();

        }
        private void dG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex == dG.NewRowIndex || e.RowIndex < 0)
                return;
            if (e.ColumnIndex == dG.Columns["Edit"].Index)
            {
                Editbook(e);
            }
        }
    }
}
