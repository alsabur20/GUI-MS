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
using System.Web;
using System.Windows.Forms;
using System.Transactions;

namespace GLMS.UI
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }
        private void addBook_btn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(bID.Text);
            string name = bName.Text;
            string author = bAuthor.Text;
            string genre = bGenre.Text;
            BookDL.AddBook(new Book(id, name, author, genre));
            ClearForm();
            MessageBox.Show("Book Added Successfully!");
        }
        private void ClearForm()
        {
            bID.Text = null;
            bName.Text = null;
            bAuthor.Text = null;
            bGenre.Text = null;
        }
    }
}
