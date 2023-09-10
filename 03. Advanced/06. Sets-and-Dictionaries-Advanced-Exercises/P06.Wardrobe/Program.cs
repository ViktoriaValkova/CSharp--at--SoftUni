namespace P06.Wardrobe
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());

			Dictionary<string, Dictionary<string, int>> clothesByCountAndColor =
				new Dictionary<string, Dictionary<string, int>>();
			for (int i = 0; i < count; i++)
			{
				string[] clothesInfo =
					Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();

				string color = clothesInfo[0];
				string[] clothes = clothesInfo[1].Split(',');

				if (!clothesByCountAndColor.ContainsKey(color))
				{
					clothesByCountAndColor[color] = new Dictionary<string, int>();
				}

				foreach (string item in clothes)
				{
					if (!clothesByCountAndColor[color].ContainsKey(item))
					{
						clothesByCountAndColor[color].Add(item, 0);
					}

					clothesByCountAndColor[color][item]++;
				}

			}
			string[] itemInfo = Console.ReadLine().Split();

			string colorToLookFor = itemInfo[0];
			string itemToLookFor = itemInfo[1];
			bool correctColor = false;
			foreach (var kvp in clothesByCountAndColor)
			{
				Console.WriteLine($"{kvp.Key} clothes:");
				if (kvp.Key == colorToLookFor)
				{
					correctColor = true;
				}
				foreach (var itemAndCount in kvp.Value)
				{
					if (correctColor && itemAndCount.Key == itemToLookFor)
					{
						Console.WriteLine($"* {itemAndCount.Key} - {itemAndCount.Value} (found!)");
						correctColor = false;
						continue;
					}
					Console.WriteLine($"* {itemAndCount.Key} - {itemAndCount.Value}");
				}
			}
		}
	}
}