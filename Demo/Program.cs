using System;
using System.Collections.Generic;

namespace Stepik
{


    class Program
    {
        public static void Main()
        {
            UserManager userManager = new UserManager();
            userManager.Register(new User("Алексей", "a.potapov@gmail.com", "qwerty123"));
            Console.WriteLine($"Пользователь {userManager.Users[0].Name} зарегистрирован");
        }

    }

    public class UserManager
    {
        public List<User> Users {get;} = new List<User>();

        public void Register(User user)
        { 
            Users.Add(user);
        }

    }

    public class User
    {
        public string Name;
        public string Email;
        public string Password;

        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }
}