using Microsoft.VisualBasic;

namespace P05.Courses
{
     class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Course, int> studentByCourse = new Dictionary<Course, int>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] courseInfo = input.Split(" : ").ToArray(); 
                string courseName = courseInfo[0];
                string student = courseInfo[1];
                Course course = studentByCourse.Keys.FirstOrDefault(c => c.Name == courseName);

                if (course== null)
                {
                    course = new Course(courseName, new List<string>());
                    studentByCourse.Add(course,0);
                }
                course.Students.Add(student);
                studentByCourse[course]++;
            }

            foreach (var course in studentByCourse)
            {
                Console.WriteLine($"{course.Key.Name}: {course.Value}");
                Console.WriteLine($"-- {string.Join("\n-- ",course.Key.Students)}");
            }
        }
    }
    class Course
    {
        public Course(string name, List<string> students)
        {
            Name = name;
            Students = students;
        }
        public string Name { get; set; }

        public List<string> Students;

    }
}