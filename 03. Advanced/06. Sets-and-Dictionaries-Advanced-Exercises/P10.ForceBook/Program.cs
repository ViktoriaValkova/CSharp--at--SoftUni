namespace P10.ForceBook
{
	internal class Program
	{
		static SortedDictionary<string, SortedSet<string>> userBySide = new SortedDictionary<string, SortedSet<string>>();
		static void Main(string[] args)
		{
			string input;

			while ((input = Console.ReadLine()) != "Lumpawaroo")
			{
				if (input.Contains('|'))
				{
					string[] cmdArg = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
					string side = cmdArg[0];
					string user = cmdArg[1];

					if (!userBySide.Values.Any(x => x.Contains(user)))
					{
						if (!userBySide.ContainsKey(side))
						{
							userBySide[side] = new SortedSet<string>();
						}
						userBySide[side].Add(user);
					}

					continue;
				}

				string[] info = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
				string newUser = info[0];
				string currentSide = info[1];

				foreach (var kvp in userBySide)
				{
					if (kvp.Value.Contains(newUser))
					{
						kvp.Value.Remove(newUser);
						break;
					}
				}

				if (!userBySide.ContainsKey(currentSide))
				{
					userBySide[currentSide] = new SortedSet<string>();
				}

				userBySide[currentSide].Add(newUser);

				Console.WriteLine($"{newUser} joins the {currentSide} side!");
			}

			var orderedUsers = userBySide.OrderByDescending(x => x.Value.Count);

			foreach (var kvp in orderedUsers.Where(x => x.Value.Count > 0))
			{
				Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");
				var currentList = kvp.Value;

				foreach (string user in currentList)
				{
					Console.WriteLine($"! {user}");
				}
			}
		}
	}
}