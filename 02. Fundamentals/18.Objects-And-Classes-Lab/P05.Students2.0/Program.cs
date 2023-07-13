namespace P05.Students2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] information = input.Split();
                string firstName = information[0];
                string lastName = information[1];
                if (IsStudentNew(students, firstName, lastName))
                {
                Student student = new Student(firstName, lastName, int.Parse(information[2]), information[3]);
                students.Add(student);
                }
                else
                {
                    Student student = GetStudent(students, firstName, lastName);
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = int.Parse(information[2]);
                    student.HomeTown = information[3];
                }

            }
            string town = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == town)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student  existingStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student; 
                }
            }

            return existingStudent;
        }

        static bool IsStudentNew(List<Student> students, string firstName, string lastName)
         {
             foreach (Student student in students)
             {
                 if (student.FirstName == firstName && student.LastName == lastName)
                 {
                     return false;
                 }
             }

             return true;
         }
    }
    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }



    }
}