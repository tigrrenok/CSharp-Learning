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
            Student stud = new Student();
            Console.WriteLine(stud.Password);

            GriffindorStudent grifStud = new GriffindorStudent();
            grifStud.BreakRules();
            Console.WriteLine(grifStud.Password);
            Console.WriteLine(((Student)grifStud).Password);
        }


    }

    public class Student
    {
        public string Password { get; set; } = "Алоомора";


        public void Spell() { }
    }

    public class GriffindorStudent : Student
    {
        public new string Password { get; set; } = "Грата Домум";


        public void BreakRules() { }
    }

    public class SlytherinStudent : Student
    {
        public new string Password { get; set; } = "Чистая кровь";


        public void Cheat() { }
    }

}