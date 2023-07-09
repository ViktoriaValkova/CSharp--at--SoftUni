namespace P05.Courses.SecondVersion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> studentByCourses = new Dictionary<string, List<string>>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] courseInfo = input.Split(" : ").ToArray();
                string courseName = courseInfo[0];
                string student = courseInfo[1];

                if (!studentByCourses.ContainsKey(courseName))
                {
                    studentByCourses[courseName] = new List<string>();
                }
                if (!studentByCourses[courseName].Contains(student))
                {
                    studentByCourses[courseName].Add(student);
                }
            }
            foreach (var course in studentByCourses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                Console.WriteLine($"-- {string.Join("\n-- ", course.Value)}");
            }
        }
    }
}