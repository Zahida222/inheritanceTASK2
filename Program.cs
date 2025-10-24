using HomeTask2.Models;
using System;

namespace HomeTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Admin məlumatlarını daxil edin.");

            string username;
            while (true)
            {
                Console.Write("Username: ");
                username = Console.ReadLine();
                if (!string.IsNullOrEmpty(username) && username.Length > 6)
                    break;
                Console.WriteLine("Username minimum 7 simvoldan ibarət olmalıdır. ");
            }

            string password;
            while (true)
            {
                Console.Write("Password: ");
                password = Console.ReadLine();
                int upperCount = 0, digitCount = 0;
                foreach (char c in password)
                {
                    if (char.IsUpper(c)) upperCount++;
                    if (char.IsDigit(c)) digitCount++;
                }
                if (upperCount >= 1 && digitCount >= 1)
                    break;
                Console.WriteLine("Password ən azı 1 böyük hərf və 1 rəqəm daxil etməlidir.");
            }

            string email;
            while (true)
            {
                Console.Write("Email (istəyə bağlı, daxil etmək istəyirsinizsə @ olmalıdır): ");
                email = Console.ReadLine();
                if (string.IsNullOrEmpty(email) || (email.Contains("@") && !"!#$%&'*+/=?^_`{|}~.-".Contains(email[0]) && !"!#$%&'*+/=?^_`{|}~.-".Contains(email[email.Length - 1])))
                    break;
                Console.WriteLine("Email düzgün formatda deyil. Yenidən daxil edin.");
            }

            bool isSuperAdmin = true;
            string section = "AzMpa201"; 

            Admin admin = Admin.CreateAdmin(username, password, section, isSuperAdmin, email);

            Console.WriteLine("\nAdmin məlumatları uğurla yaradıldı:");
            admin.DisplayAdminInfo();

            
            
        }
    }
}
