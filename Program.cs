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
        if (User.IsValidUsername(username))
            break;
        Console.WriteLine("Username minimum 7 simvoldan ibarət olmalıdır. ");
    }

    string password;
    while (true)
    {
        Console.Write("Password: ");
        password = Console.ReadLine();
        if (User.IsValidPassword(password))
            break;
        Console.WriteLine("Password ən azı 1 böyük hərf və 1 rəqəm daxil etməlidir.");
    }

    string email;
    while (true)
    {
        Console.Write("Email (istəyə bağlı, daxil etmək istəyirsinizsə @ olmalıdır): ");
        email = Console.ReadLine();
        if (string.IsNullOrEmpty(email) || User.IsValidEmail(email)) 
            break;
        Console.WriteLine("Email düzgün formatda deyil. Yenidən daxil edin.");
    }

    bool isSuperAdmin = true;

    string section;
    while (true)
    {
        Console.Write("Section:");
        section= Console.ReadLine();
        if (!string.IsNullOrEmpty(section))
            break;
    }

     

    Admin admin = Admin.CreateAdmin(username, password, section, isSuperAdmin, email);

    Console.WriteLine("\nAdmin məlumatları uğurla yaradıldı:");
    admin.DisplayAdminInfo();

    
    
}
    }
}
