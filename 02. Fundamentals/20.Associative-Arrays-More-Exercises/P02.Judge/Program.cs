using System.Diagnostics.Metrics;
using System.Xml.XPath;

namespace P02.Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, Dictionary<string, int>> usersByContest =
                new Dictionary<string, Dictionary<string, int>>();
            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] contestInfo = input.Split(" -> ").ToArray();
                string userName = contestInfo[0];
                string contest = contestInfo[1];
                int points = int.Parse(contestInfo[2]);

                if (!usersByContest.ContainsKey(contest))
                {
                    usersByContest[contest] = new Dictionary<string, int>();
                    usersByContest[contest][userName] = points;
                }

                if (!usersByContest[contest].ContainsKey(userName))
                {
                    usersByContest[contest][userName] = points;
                }

                if (usersByContest[contest][userName] < points)
                {
                    usersByContest[contest][userName] = points;
                }
            }

            foreach (var kvp in usersByContest)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} participants");
                int counter = 1;
                foreach (var user in kvp.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {

                    Console.WriteLine($"{counter}. {user.Key} <::> {user.Value}");
                    counter++;
                }
            }

            Console.WriteLine("Individual standings:");

            Dictionary<string, int> totalPointsByUser = new Dictionary<string, int>();

            foreach (var kvp in usersByContest)
            {
                foreach (var userInfo in kvp.Value)
                {
                    string userName = userInfo.Key;
                    int points = userInfo.Value;
                    if (!totalPointsByUser.ContainsKey(userName))
                    {
                        totalPointsByUser[userName] = 0;
                    }

                    totalPointsByUser[userName] += points;
                }
            }
            totalPointsByUser = totalPointsByUser
                .OrderByDescending(x=>x.Value)
                .ThenBy(x=>x.Key)
                .ToDictionary(a=>a.Key, b=>b.Value);

            int position = 1;
            foreach (var user in totalPointsByUser)
            {
                Console.WriteLine($"{position}. {user.Key} -> {user.Value}");
                position++;
            }
        }
    }
}
