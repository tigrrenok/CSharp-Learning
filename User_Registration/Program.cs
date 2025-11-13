using System;
using System.Collections.Generic;

namespace Stepik
{


    partial class Program
    {
        public static void Main()
        {
            EventArgs arg = new UserRegisteredEventArgs("Test2@yandex.ru");

            var info = typeof(UserRegisteredEventArgs).GetProperty("Email");
            if (info.CanWrite == false)
                Console.WriteLine("Ok");
            else
                throw new Exception("Свойство Email должно быть только для чтения");

            User user = new User("Ivan Ivanov", "ivanov@yandex.ru", "123321");

            UserManager userManager = new UserManager();
            var advertisement = new Advertisement(userManager);
            advertisement.TurnOn();

            userManager.Register(user);


        }
    }
}