namespace P04.Students.Second
{
     class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < count; i++)
            {
                string[] studentInfo = Console.ReadLine().Split();
                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                decimal grade = decimal.Parse(studentInfo[2]);
                students.Add(new Student(firstName,lastName,grade));
            }

          List<Student>orderedStudents = students.OrderByDescending(s => s.Grade).ToList();
          foreach (Student student in orderedStudents)
          {
              Console.WriteLine(student);
          }
        }
    }
     class Student
    {
        public Student(string firstName, string lastName, decimal grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public decimal Grade { get; set; }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
        }
    }
}