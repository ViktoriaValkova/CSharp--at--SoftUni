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

			foreach (var kvp in clothesByCountAndColor)
			{
				Console.WriteLine($"{kvp.Key} clothes:");
				
				foreach (var itemAndCount in kvp.Value)
				{
					string result = $"* {itemAndCount.Key} - {itemAndCount.Value}";
					if (kvp.Key==colorToLookFor && itemAndCount.Key == itemToLookFor)
					{
						result += " (found!)";
					}

					Console.WriteLine(result);
				}
			}
		}
	}
}