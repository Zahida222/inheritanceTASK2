using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2.Models
{
    internal class Admin : User
    {
        public bool IsSuperAdmin { get; private set; }
        public string Section { get; private set; }

        private Admin(string username, string password, bool isSuperAdmin, string section, string email = "")
            : base(username, password, email)
        {
            IsSuperAdmin = isSuperAdmin;
            Section = section;
        }

        public static Admin CreateAdmin(string username, string password, string section, bool isSuperAdmin, string email = "")
        {
            if (username == "" || password == "" || section == "")
                return null;

            User tempUser = new User(username, password, email);

            if (tempUser.Username == "" || tempUser.Password == "")
                return null;

            return new Admin(tempUser.Username, tempUser.Password, isSuperAdmin, section, tempUser.Email);
        }

        public void DisplayAdminInfo()
        {
            DisplayInfo();
            Console.WriteLine("SuperAdmin: " + IsSuperAdmin);
            Console.WriteLine("Section: " + Section);
        }
    }
}

