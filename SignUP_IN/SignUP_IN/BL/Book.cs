using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GLMS.BL
{
    public class Book
    {
        private int bookID;
        private string bookName;
        private string author;
        private string genre;
        private bool isIssued;
        private DateTime issueDate;
        private DateTime returnDate;
        private string issuer;
        public Book(int bookID, string bookName, string author, string genre)
        {
            this.BookID = bookID;
            this.BookName = bookName;
            this.Author = author;
            this.Genre = genre;
            this.IsIssued = false;
            this.Issuer = "";
        }
        public Book(int bookID, string bookName, string author, string genre, bool isIssued, DateTime issueDate, DateTime returnDate, string issuer)
        {
            this.BookID = bookID;
            this.BookName = bookName;
            this.Author = author;
            this.Genre = genre;
            this.IsIssued = isIssued;
            this.IssueDate = issueDate;
            this.ReturnDate = returnDate;
            this.Issuer = issuer;
        }
        public int BookID { get => bookID; set => bookID = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public string Author { get => author; set => author = value; }
        public string Genre { get => genre; set => genre = value; }
        public bool IsIssued { get => isIssued; set => isIssued = value; }
        public DateTime IssueDate { get => issueDate; set => issueDate = value; }
        public DateTime ReturnDate { get => returnDate; set => returnDate = value; }
        public string Issuer { get => issuer; set => issuer = value; }

        public void IssueBook(string name)
        {
            this.IsIssued = true;
            this.IssueDate = DateTime.Now;
            this.ReturnDate = DateTime.Now.AddDays(7);
            this.Issuer = name;
        }
        public void ReturnBook()
        {
            this.IsIssued = false;
            this.IssueDate = default(DateTime);
            this.ReturnDate = default(DateTime);
            this.Issuer = "";
        }
        public void ModifyBook(string name)
        {
            this.Author = name;
        }
        public string GetName()
        {
            return this.BookName;
        }
        public int GetId()
        {
            return this.BookID;
        }
        public bool GetStatus()
        {
            return this.IsIssued;
        }
        public DateTime GetIssueDate()
        {
            return this.IssueDate;
        }
        public DateTime GetReturnDate()
        {
            return this.ReturnDate;
        }
        public string GetIssuer()
        {
            return this.Issuer;
        }
        public void SetStatus(bool status)
        {
            this.IsIssued = status;
        }
        public void SetDate(DateTime issueDate)
        {
            this.IssueDate = issueDate;
        }
        public void SetIssuer(string name)
        {
            this.Issuer = name;
        }
        public string WriteToFile()
        {
            if (this.IsIssued)
            {
                return this.BookID + "," + this.BookName + "," + this.Author + "," + this.Genre + "," + this.IsIssued + "," + this.IssueDate.ToShortDateString() + "," + this.ReturnDate.ToShortDateString() + "," + this.Issuer;
            }
            else
            {
                return this.BookID + "," + this.BookName + "," + this.Author + "," + this.Genre + "," + this.IsIssued;

            }
        }
        public bool IsBookLate(DateTime date)
        {
            if (date > this.ReturnDate)
            {
                return true;
            }
            else return false;
        }

        public string toString()
        {
            string book = this.BookID.ToString().PadRight(10) + this.BookName.PadRight(20) + this.Author.PadRight(20) + this.Genre.PadRight(20);
            if (this.IsIssued)
            {
                book += "Issued".PadRight(20) + this.IssueDate.ToShortDateString().PadRight(20)+ this.ReturnDate.ToShortDateString().PadRight(20)+ this.Issuer.PadRight(20);
            }
            else
            {
                book += "Not Issued".PadRight(20);
            }
            return book;
        }
    }
}