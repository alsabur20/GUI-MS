using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GLMS.BL;

namespace GLMS.DL
{
    class UserDL
    {
        private static List<User> users = new List<User>();

        public static List<User> Users { get => users; set => users = value; }

        public static void AddUser(User temp)
        {
            Users.Add(temp);
        }
        public static User GetUser(string name)
        {
            foreach (User x in Users)
            {
                if (name == x.GetUserName())
                {
                    return x;
                }
            }
            return null;
        }
        public static User GetUser(User temp)
        {
            foreach (User x in Users)
            {
                if (temp.GetUserName() == x.GetUserName() && temp.GetPassword() == x.GetPassword())
                {
                    return x;
                }
            }
            return null;
        }
        public static void WriteUsersData()
        {
            string path = "membersdata.txt";
            StreamWriter myFile = new StreamWriter(path);
            foreach (User x in Users)
            {
                if (x is Student)
                {
                    myFile.WriteLine(x.WriteToFile());
                }
                else if (x is Admin)
                {
                    myFile.WriteLine(x.WriteToFile());
                }
            }
            myFile.Flush();
            myFile.Close();

        }
        public static void LoadUsersData()
        {
            string path = "membersdata.txt";
            if (File.Exists(path))
            {
                users.Clear();
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    string[] data = record.Split(',');
                    if (bool.Parse(data[data.Length - 1]))
                    {
                        Admin temp = new Admin(data[0], data[1], data[2], bool.Parse(data[3]));
                        AddUser(temp);
                    }
                    else
                    {
                        Student temp = new Student(data[0], data[1], data[2], int.Parse(data[3]), bool.Parse(data[4]));
                        AddUser(temp);
                    }
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("Data Loading Errors");
            }
        }
    }
}
