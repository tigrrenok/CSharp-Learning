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
            List<Profile> profiles = new List<Profile>
    {
        new Vacancy("C# разработчик", 100000),
        new Vacancy("Python разработчик", 90000),
        new Vacancy("C++ разработчик", 110000),
        new Resume("C# разработчик", 4),
        new Resume("C++ разработчик", 1),
    };

            foreach (var profile in profiles)
            {
                profile.Describe();
            }
        }


    }

    public class Profile
    {   
        public string Profession { get; set; }
        public Profile (string profession)
        {  Profession = profession; }

        public virtual string GetInfo()
        {
            return "";
        }
        public void Describe()
        {
            Console.WriteLine($"{Profession} {GetInfo()}");
        }


    }
    public class Vacancy : Profile
    {
        public int Salary { get; set; }
        public Vacancy(string profession, int salary) : base(profession)
        {
            Salary = salary;
        }
        public override string GetInfo()
        {
            return $"Предлагаемая зарплата: {Salary}";
        }
    }

    public class Resume : Profile
    {
        public int Stag { get; set; }
        public Resume(string profession, int stag) : base(profession)
        {
            Stag = stag;
        }
        public override string GetInfo()
        {
            return $"Стаж работы: {Stag}";
        }
    }




}