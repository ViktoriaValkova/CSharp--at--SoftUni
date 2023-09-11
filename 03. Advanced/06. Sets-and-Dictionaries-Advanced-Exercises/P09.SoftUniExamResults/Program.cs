namespace P09.SoftUniExamResults
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = string.Empty;
			Dictionary<string, Dictionary<string, int>> examsByUsers = new Dictionary<string, Dictionary<string, int>>();
			Dictionary<string, int> submissionsByLanguage = new Dictionary<string, int>();
			while ((input = Console.ReadLine()) != "exam finished")
			{
				string[] examInfo = input.Split('-').ToArray();
				string userName = examInfo[0];

				if (examInfo[1] == "banned")
				{
					examsByUsers.Remove(userName);
						continue;  
				}
				string language = examInfo[1];
				int points = int.Parse(examInfo[2]);

				if (!examsByUsers.ContainsKey(userName))
				{
					examsByUsers[userName] = new Dictionary<string, int>();
				}
				if (!examsByUsers[userName].ContainsKey(language))
				{
					examsByUsers[userName].Add(language, 0);
				}
				if (examsByUsers[userName][language] < points)
				{
					examsByUsers[userName][language] = points;
				}
				if (!submissionsByLanguage.ContainsKey(language))
				{
					submissionsByLanguage[language] = 0;
				}

				submissionsByLanguage[language]++;
			}

			var orderedUsers = examsByUsers.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key);
			Console.WriteLine("Results:");
			foreach (var user in orderedUsers)
			{
				Console.WriteLine($"{user.Key} | {user.Value.Values.Sum()}");
			}

			var orderedSubmissions = submissionsByLanguage.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

			Console.WriteLine("Submissions:");

			foreach (var submission in orderedSubmissions)
			{
				Console.WriteLine($"{submission.Key} - {submission.Value}");
			}
		}
	}
}