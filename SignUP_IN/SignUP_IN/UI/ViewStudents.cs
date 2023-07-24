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
    public partial class ViewStudents : Form
    {
        public ViewStudents()
        {
            InitializeComponent();
            DataBind();
            SetHeaders();
        }
        private void DataBind()
        {
            dG.DataSource = null;
            dG.DataSource= GetUsers();
            dG.Refresh();
        }
        private List<Tuple<string, int, int>> GetUsers()
        {
            List<Tuple<string, int,int>> tuples = new List<Tuple<string, int, int>>();
            foreach(User x in UserDL.Users)
            {
                if (x is Student s)
                {
                    Tuple<string, int,int> y = new Tuple<string, int,int>(s.GetName(),s.Jamat,s.IssuedBooks.Count);
                    tuples.Add(y);
                }
            }
            return tuples;
        }
        private void SetHeaders()
        {
            dG.Columns[0].HeaderText = "Name";
            dG.Columns[1].HeaderText = "Grade";
            dG.Columns[2].HeaderText = "Issued Books";
        }
    }
}
