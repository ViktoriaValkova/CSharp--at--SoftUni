namespace P05.Students2._0.SecondVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] information = Console.ReadLine().Split();
                string firstName = information[0];
                string lastName = information[1];
                int age = int.Parse(information[2]);
                string hometown = information[3];

                Student student = students.FirstOrDefault(student =>
                    student.FirstName == firstName && student.LastName == lastName);

                if (student == null)
                {
                    students.Add(new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Hometown = hometown

                    });
                }
                else
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.Hometown = hometown;
                }

            }

            string town = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.Hometown == town)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Hometown { get; set; }
        }
    }