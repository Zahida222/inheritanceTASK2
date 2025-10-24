using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2.Models
{
    internal class User
    {
        private string _username;
        private string _password;
        private string _email;

        public string Username
        {
            get { return _username; }
            set
            {
                if (IsValidUsername(value))
                    _username = value;
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (IsValidPassword(value))
                    _password = value;
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (value == "" || value == null)
                {
                    _email = "";
                }
                else if (IsValidEmail(value))
                {
                    _email = value;
                }
            }
        }

        public User(string username, string password, string email = "")
        {
            Username = username;
            Password = password;
            Email = email;
        }

        private bool IsValidUsername(string username)
        {
            return username.Length > 6;
        }

        private bool IsValidPassword(string password)
        {
            int upperCount = 0;
            int digitCount = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 'A' && password[i] <= 'Z')
                    upperCount++;
                if (password[i] >= '0' && password[i] <= '9')
                    digitCount++;
            }

            if (upperCount >= 1 && digitCount >= 1)
                return true;
            else
                return false;
        }

        private bool IsValidEmail(string email)
        {
            if (!email.Contains("@")) return false;

            string specialChars = "!#$%&'*+/=?^_`{|}~.-";
            if (specialChars.Contains(email[0]) || specialChars.Contains(email[email.Length - 1]))
                return false;

            return true;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Username: " + Username);
            Console.WriteLine("Password: " + Password);
            Console.WriteLine("Email: " + (Email == "" ? "Email daxil edilməyib" : Email));
        }
    }
}

