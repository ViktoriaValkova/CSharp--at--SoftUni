namespace P06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<double>> studentGrades = new Dictionary<string,List<double>>();

            int studentCnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentCnt; i++)
            {
                string studentName = Console.ReadLine();

                if (!studentGrades.ContainsKey(studentName))
                {
                    studentGrades[studentName] = new List<double>();
                }

                double grade = double.Parse(Console.ReadLine());
                studentGrades[studentName].Add(grade);
            }

            studentGrades = studentGrades.Where(s => s.Value.Average() >= 4.5).ToDictionary(a=>a.Key, b=>b.Value);

            foreach (var student in studentGrades)
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }
        }
    }
}