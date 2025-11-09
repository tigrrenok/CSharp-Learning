namespace App
{
    public class Student
    {
        public string FirstName;
        public string LastName;

        public Student(string FirstName, string LastName)
        { 
            this.FirstName = FirstName;
            this.LastName = LastName;   
        }

        public string PrintStudent()
        { 
            return FirstName + " " + LastName;
        }
    }
}