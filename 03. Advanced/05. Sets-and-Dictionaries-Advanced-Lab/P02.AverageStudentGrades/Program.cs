namespace P02.AverageStudentGrades
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int studentsCount = int.Parse(Console.ReadLine());
			Dictionary<string, List<decimal>> gradesByStudent = new Dictionary<string, List<decimal>>();

			for (int i = 0; i < studentsCount; i++)
			{
				string[] studentInfo = Console.ReadLine().Split();

				string studentName = studentInfo[0];
				decimal grade = decimal.Parse(studentInfo[1]);

				if (!gradesByStudent.ContainsKey(studentName))
				{
					gradesByStudent.Add(studentName, new List<decimal>());
				}

				gradesByStudent[studentName].Add(grade);
			}

			foreach (var kvp in gradesByStudent)
			{
				Console.Write($"{kvp.Key} -> ");
				kvp.Value.ForEach(x=>Console.Write($"{x:f2} "));
				Console.WriteLine($"(avg: {kvp.Value.Average():f2})");
			}
		}
	}
}