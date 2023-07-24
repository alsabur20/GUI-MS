using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GLMS.BL
{
    public class Admin : User
    {
        private bool isAdmin;
        public Admin(string name, string username, string password,bool isAdmin) : base(name,username,password)
        {
            this.isAdmin = isAdmin;
        }
        public override string WriteToFile()
        {
            return base.WriteToFile()+this.isAdmin;
        }
        public override string toString()
        {
            return base.toString();
        }
    }
}
