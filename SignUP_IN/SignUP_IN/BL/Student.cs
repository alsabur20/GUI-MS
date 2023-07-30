using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GLMS.BL
{
    public class Student : User
    {
        private bool isAdmin;
        private int jamat;
        private List<Book> issuedBooks = new List<Book>();

        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }
        public int Jamat { get => jamat; set => jamat = value; }
        public List<Book> IssuedBooks { get => issuedBooks; set => issuedBooks = value; }

        public void IssueBook(Book x)
        {
            this.IssuedBooks.Add(x);
        }
        public void ReturnBook(Book x)
        {
            this.IssuedBooks.Remove(x);
        }
        public Student(string name, string username, string password, int jamat, bool isAdmin) : base(name, username, password)
        {
            this.IsAdmin = isAdmin;
            this.Jamat = jamat;
            this.IssuedBooks = new List<Book>();
        }
        public Student(string name, string username, string password, int jamat) : base(name, username, password)
        {
            this.IsAdmin = false;
            this.Jamat = jamat;
            this.IssuedBooks = new List<Book>();
        }
        public override string WriteToFile()
        {
            return base.WriteToFile() + this.Jamat.ToString() + "," + this.IsAdmin;
        }
        public override string toString()
        {
            return base.toString() + " " + ", Class: " + this.Jamat;
        }
        public int CountLateBooks()
        {
            int counter = 0;
            foreach (Book b in this.IssuedBooks)
            {
                if (b.IsBookLate(DateTime.Now))
                {
                    counter++;
                }
            }
            return counter;
        }
        public List<Book> ReturnLateBooks()
        {
            List<Book> LateBooks = new List<Book>();
            foreach (Book b in this.IssuedBooks)
            {
                if (b.IsBookLate(DateTime.Now))
                {
                    LateBooks.Add(b);
                }
            }
            return LateBooks;
        }
    }
}