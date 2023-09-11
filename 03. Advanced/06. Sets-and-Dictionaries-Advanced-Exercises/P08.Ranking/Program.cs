namespace P08.Ranking
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> passwordByContest = new Dictionary<string, string>();

			string input = string.Empty;

			while ((input = Console.ReadLine()) != "end of contests")
			{
				string[] contestInfo = input.Split(':').ToArray();

				string contestName = contestInfo[0];
				string password = contestInfo[1];

				passwordByContest[contestName] = password;
			}

			Dictionary<string, Dictionary<string, int>> contestsByUser =
				new Dictionary<string, Dictionary<string, int>>();

			while ((input = Console.ReadLine()) != "end of submissions")
			{
				string[] userInfo = input.Split("=>").ToArray();

				string contestName = userInfo[0];
				string password = userInfo[1];
				string userName = userInfo[2];
				int points = int.Parse(userInfo[3]);

				if (passwordByContest.ContainsKey(contestName))
				{
					if (passwordByContest[contestName] == password)
					{
						if (!contestsByUser.ContainsKey(userName))
						{
							contestsByUser[userName] = new Dictionary<string, int>();
						}
						if (!contestsByUser[userName].ContainsKey(contestName))
						{
							contestsByUser[userName][contestName] = 0;
						}
						if (contestsByUser[userName][contestName] < points)
						{
							contestsByUser[userName][contestName] = points;
						}
					}
				}
			}

			var bestStudent = contestsByUser.OrderByDescending(x => x.Value.Values.Sum()).FirstOrDefault();
			Console.WriteLine($"Best candidate is {bestStudent.Key} with total {bestStudent.Value.Values.Sum()} points.");

			var orderedStudents = contestsByUser.OrderBy(x => x.Key);
			Console.WriteLine("Ranking:");
			foreach (var kvp in orderedStudents)
			{
				Console.WriteLine(kvp.Key);

				foreach (var pair in kvp.Value.OrderByDescending(x=>x.Value))
				{
					Console.WriteLine($"#  {pair.Key} -> {pair.Value}");
				}
			}
		}
	}
}