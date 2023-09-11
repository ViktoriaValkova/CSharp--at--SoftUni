namespace P07.The_V_Logger
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, Dictionary<string, HashSet<string>>> vloggersByFollowers = new Dictionary<string, Dictionary<string, HashSet<string>>>();

			string input = string.Empty;

			while ((input = Console.ReadLine()) != "Statistics")
			{
				string[] info = input.Split();
				string vloggername = info[0];
				if (info.Contains("joined"))
				{
					if (!vloggersByFollowers.ContainsKey(vloggername))
					{
						vloggersByFollowers[vloggername] = new Dictionary<string, HashSet<string>>();
						vloggersByFollowers[vloggername].Add("followers", new HashSet<string>());
						vloggersByFollowers[vloggername].Add("following", new HashSet<string>());
					}
				}
				else
				{
					string follower = info[0];
					string vloggerToFollow = info[2];
					if (follower != vloggerToFollow && vloggersByFollowers.ContainsKey(vloggerToFollow) && vloggersByFollowers.ContainsKey(follower))
					{
						vloggersByFollowers[vloggerToFollow]["followers"].Add(follower);
						vloggersByFollowers[follower]["following"].Add(vloggerToFollow);
					}
				}
			}

			Console.WriteLine($"The V-Logger has a total of {vloggersByFollowers.Count} vloggers in its logs.");

			var orderedByCountFollowers = vloggersByFollowers.OrderByDescending(x => x.Value["followers"].Count)
				.ThenBy(x => x.Value["following"].Count).ToDictionary(x => x.Key, x => x.Value);

			int i = 1;
			foreach (var kvp in orderedByCountFollowers)
			{
				Console.WriteLine($"{i}. {kvp.Key} : {kvp.Value["followers"].Count} followers, {kvp.Value["following"].Count} following");
				if (i == 1)
				{
					Console.WriteLine($"*  {string.Join("\n*  ", kvp.Value["followers"].OrderBy(x => x))}");
				}

				i++;
			}
		}
	}
}
