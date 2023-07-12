using System.Diagnostics.CodeAnalysis;

namespace P01.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var passwordByContest = AddContestsWithPass();

            string input;
            Dictionary<string, List<Contest>> contestsByStudent = new Dictionary<string, List<Contest>>();
            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] studentInfo = input.Split("=>").ToArray();
                string contestName = studentInfo[0];
                string password = studentInfo[1];
                string userName = studentInfo[2];
                int points = int.Parse(studentInfo[3]);

                if (passwordByContest.ContainsKey(contestName) && passwordByContest[contestName] == password) //contest valid, pass correct
                {
                    if (!contestsByStudent.ContainsKey(userName)) //student is not present
                    {
                        contestsByStudent[userName] = new List<Contest> // student is added 
                        {
                            new Contest(contestName, points) // this contest and points are added 
                        };
                    }
                    // this foundContest is the missing part, remember 
                    Contest foundContest = contestsByStudent[userName].FirstOrDefault(c => c.Name == contestName);
                    if (foundContest == null)
                    {
                        contestsByStudent[userName].Add(new Contest(contestName, points));
                    }
                    else if (foundContest.Points < points)
                    {
                        foundContest.Points = points;
                    }
                }
            }
            int bestPoints = int.MinValue;
            string bestStudent=string.Empty;    
            foreach (var kvp in contestsByStudent)
            {
                int sum = kvp.Value.Sum(c => c.Points);
                if (sum > bestPoints)
                {
                    bestPoints=sum;
                    bestStudent=kvp.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestStudent} with total {bestPoints} points.");
            PrintRanking(contestsByStudent);
        }

        private static Dictionary<string, string> AddContestsWithPass()
        {
            string contests;
            Dictionary<string, string> passwordByContest = new Dictionary<string, string>();
            while ((contests = Console.ReadLine()) != "end of contests")
            {
                string[] contestInsfo = contests.Split(":").ToArray();
                string contest = contestInsfo[0];
                string password = contestInsfo[1];

                passwordByContest[contest] = password;
            }

            return passwordByContest;
        }

        private static void PrintRanking(Dictionary<string, List<Contest>> contestsByStudent)
        {
            Console.WriteLine("Ranking:");
            var orderedByStudentName = contestsByStudent.OrderBy(x => x.Key);
            foreach (var kvp in orderedByStudentName)
            {
                Console.WriteLine(kvp.Key);
                var orderedContests = kvp.Value.OrderByDescending(x => x.Points);
                foreach (Contest contest in orderedContests)
                {
                    Console.WriteLine($"#  {contest.Name} -> {contest.Points}");
                }
            }
        }
    }
    class Contest
    {
        public Contest(string name, int points)
        {
            Name = name;
            Points = points;
        }
        public string Name { get; set; }
        public int Points { get; set; }

    }
}