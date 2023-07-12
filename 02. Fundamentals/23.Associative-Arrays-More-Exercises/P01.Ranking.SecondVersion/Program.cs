using System.Security.Cryptography;
using System.Linq;

namespace P01.Ranking.SecondVersion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> passwordByContest = new Dictionary<string, string>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] contestAndPass = input.Split(':').ToArray();

                passwordByContest[contestAndPass[0]] = contestAndPass[1];
            }

            Dictionary<string, Dictionary<string, int>> contestsByStudent =
                new Dictionary<string, Dictionary<string, int>>();

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] studentInfo = input.Split("=>").ToArray();
                string contest = studentInfo[0];
                string pass = studentInfo[1];
                string name = studentInfo[2];
                int points = int.Parse(studentInfo[3]);

                if (passwordByContest.ContainsKey(contest) && passwordByContest[contest] == pass)
                {
                    if (!contestsByStudent.ContainsKey(name))
                    {
                        contestsByStudent[name] = new Dictionary<string, int>();
                        contestsByStudent[name][contest] = points;
                    }
                    else if (!contestsByStudent[name].ContainsKey(contest))
                    {
                        contestsByStudent[name][contest] = points;
                    }
                    else if (contestsByStudent[name][contest] < points) // this!
                    {
                        contestsByStudent[name][contest] = points;
                    }
                }

            }
            var bestStudent = contestsByStudent.MaxBy(kvp => kvp.Value.Values.Sum());
            Console.WriteLine($"Best candidate is {bestStudent.Key} with total {bestStudent.Value.Values.Sum()} points.");

            Console.WriteLine("Ranking:");
            foreach (var student in contestsByStudent.OrderBy(x => x.Key))
            {
                Console.WriteLine(student.Key);
                foreach (var kvp in student.Value.OrderByDescending(kvp => kvp.Value))
                {
                    Console.WriteLine($"#  {kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}