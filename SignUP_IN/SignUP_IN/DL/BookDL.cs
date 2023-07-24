using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GLMS.BL;

namespace GLMS.DL
{
    class BookDL
    {
        private static List<Book> books = new List<Book>();

        public static List<Book> Books { get => books; set => books = value; }

        public static void AddBook(Book x)
        {
            Books.Add(x);
            WriteBooksData();
        }
        public static void DeleteBook(int index)
        {
            Books.RemoveAt(index);
            WriteBooksData();
        }
        public static List<Book> SearchBook(string s)
        {
            List<Book> books = Books.FindAll(item => item.GetName().StartsWith(s));
            return books;
        }
        public static int ReturnBookIndex(int bookid)
        {
            int index = -1;
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].GetId() == bookid)
                {
                    index = i;
                }
            }
            return index;
        }
        public static int ReturnBookIndex(string bookname)
        {
            int index = -1;
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].GetName() == bookname)
                {
                    index = i;
                }
            }
            return index;
        }
        public static Book ReturnBookFromString(string name)
        {
            foreach (Book x in Books)
            {
                if (x.GetName() == name)
                {
                    return x;
                }
            }
            return null;
        }
        public static bool DoesBookExist(Book temp)
        {
            foreach (Book x in Books)
            {
                if (x.GetId() == temp.GetId())
                {
                    return true;
                }
            }
            return false;
        }
        public static void ReadBooksData()
        {
            string path = "booksData.txt";
            if (File.Exists(path))
            {
                Books.Clear();
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    string[] data = record.Split(',');
                    Book temp;
                    if (bool.Parse(data[4]))
                    {
                        string[] date = data[5].Split('/');
                        string[] date1 = data[6].Split('/');
                        temp = new Book(int.Parse(data[0]), data[1], data[2], data[3], bool.Parse(data[4]), new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0])), new DateTime(int.Parse(date1[2]), int.Parse(date1[1]), int.Parse(date1[0])), data[7]);
                        if (UserDL.GetUser(data[7]) is Student student)
                        {
                            student.IssueBook(temp);
                        }
                    }
                    else
                    {
                        temp = new Book(int.Parse(data[0]), data[1], data[2], data[3]);
                    }
                    Books.Add(temp);
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("Data Loading Errors");
            }
        }
        public static void WriteBooksData()
        {
            string path = "booksData.txt";
            StreamWriter myFile = new StreamWriter(path);
            foreach (Book x in Books)
            {
                myFile.WriteLine(x.WriteToFile());
            }
            myFile.Flush();
            myFile.Close();
        }
    }
}
