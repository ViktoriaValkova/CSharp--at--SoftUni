using System;
using System.Security.AccessControl;

namespace P04.Students
{
     public class Program
    {
        static void Main(string[] args)
        {
            int studentCnt = int.Parse(Console.ReadLine());
            StudentsList studentsList = new StudentsList();
            for (int i = 0; i < studentCnt; i++)
            {
                string[] information = Console.ReadLine().Split();

                Student student = new Student(information[0], information[1], decimal.Parse(information[2]));
                
                studentsList.Students.Add(student);
            }
            List<Student> sortedStudents = studentsList.Students.OrderByDescending(student => student.Grade).ToList();

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }
        }
    }

    public class StudentsList
     {
         public StudentsList()
        {
            this.Students = new List<Student>();
        }
         public List<Student> Students { get; set; }
     }

   public  class Student
    {
      public Student(string firstName, string lastName, decimal grade)
      {
          this.FirstName = firstName;
          this.LastName = lastName;
          this.Grade = grade;
      }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Grade { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} {this.Grade}";
        }

        
    }
}