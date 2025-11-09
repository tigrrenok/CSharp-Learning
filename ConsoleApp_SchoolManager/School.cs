namespace App
{
    public class School
    {
        public string Name;
        public List<Student> Students = new List<Student>();

        public School(string name)
        {
            Name = name;
        }
        public void PrintStudent()
        {
            for (int i = 0; i < Students.Count; i++)
            {
                Console.Write((i + 1) + ": ");
                Console.WriteLine(Students[i].PrintStudent());
            }
            if (Students.Count == 0)
            {
                Console.WriteLine($"В школе {Name} пока нет студентов");
            }
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
            Console.WriteLine($"Ученик {student.FirstName} {student.LastName} успешно добавлен в школу {Name}");
        }

    }
}