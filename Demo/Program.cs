using System;
using System.Drawing;
using System.Globalization;
using System.Net.Sockets;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

namespace Figure_classes
{
    class Program
    {
        public static void Main()
        {
            User user = new User("Josef");
            Console.WriteLine(user.GetInfo());
            user.SendMessage(user, "123");
            user.Post("123123");

            Person person = new Person("Josef", 15);
            Console.WriteLine(person.GetInfo());
            person.SendMessage(person, "123");
            person.Post("123123");
            person.Subscribe(person);

            Community community = new Community("Josef", "desc");
            Console.WriteLine(community.GetInfo());
            community.SendMessage(community, "123");
            community.Post("123123");
        }


    }

    public class User
    { 
        public string Name { get; set; }
        public User(string name)
        {
            Name = name;
        }

        public void SendMessage(User user, string message)
        { 
            
        }

        public void Post(string message)
        { 
        
        }

        public string GetInfo()
        {
            return $"Имя={Name}";
        }
    }

    public class Person : User
    {
        public int Age { get; set; }
        public Person(string name, int age) : base(name)
        {
            Age = age;
        }
        public new string GetInfo()
        {
            return $"Имя={Name}, Возраст={Age}";
        }

        public void Subscribe(User user) { }
    }

    public class Community : User
    {
        public string Descriptuin { get; set; }
        public Community(string name, string descriptuin) : base(name) 
        {
            Descriptuin = descriptuin;
        }
        public new string GetInfo()
        {
            return $"Имя={Name}, Описание={Descriptuin}";
        }
    }

}