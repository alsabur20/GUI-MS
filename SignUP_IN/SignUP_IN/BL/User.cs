using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GLMS.BL
{
    public class User
    {
        private string name;
        private string username;
        private string password;
        private string role;

        public User(string username,string password)
        {
            this.Username = username;
            this.Password = password;
        }
        public User(string name, string username, string password)
        {
            this.Name = name;
            this.Username = username;
            this.Password = password;
        }
        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }

        public string GetName()
        {
            return this.Name;
        }
        public string GetUserName()
        {
            return this.Username;
        }
        public string GetPassword()
        {
            return this.Password;
        }
        public virtual string WriteToFile()
        {
            return this.Name + "," + this.Username + "," + this.Password+",";
        }
        public virtual string toString()
        {
            return "Name: " + this.Name + " " + ", Username: " + this.Username;
        }
    }
}