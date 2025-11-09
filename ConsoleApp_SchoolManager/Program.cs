using System;
using System.Net.Sockets;
using System.Xml.Linq;

namespace App
{
    class Program
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            School school = new School(name);
            Student student;
            Console.WriteLine("Школа <название школы> успешно создана.");
            while (true)
            {
                Console.WriteLine("Хотите посмотреть список всех учеников школы <название школы>?");
                string answer = Console.ReadLine().ToLower().Trim();
                if (answer == "да" || answer == "yes")
                {
                    Console.WriteLine("Вот ученики школы:");
                    school.PrintStudent();
                }
                Console.WriteLine("Хотите добавить нового ученика?");
                answer = Console.ReadLine().ToLower();
                if (answer == "да" || answer == "yes")
                {
                    Console.WriteLine("Введите имя ученика");
                    string studentName = Console.ReadLine();
                    Console.WriteLine("Введите фамилию ученика");
                    string studentSurname = Console.ReadLine();
                    student = new Student(studentName, studentSurname);
                    school.AddStudent(student);
                }
            }
        }
    }
}