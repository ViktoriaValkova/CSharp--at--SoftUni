namespace P05.CitiesByContinentAndCountry
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());
			Dictionary<string, Dictionary<string, List<string>>> citiesByContinentsByCountry =
				new Dictionary<string, Dictionary<string, List<string>>>();
			for (int i = 0; i < count; i++)
			{
				string[] info = Console.ReadLine().Split(); 

				string continent = info[0];
				string country = info[1];
				string city = info[2];

				if (!citiesByContinentsByCountry.ContainsKey(continent))
				{
					citiesByContinentsByCountry[continent]=new Dictionary<string, List<string>>();
				}

				if (!citiesByContinentsByCountry[continent].ContainsKey(country))
				{
					citiesByContinentsByCountry[continent][country]=new List<string>();
				}

				citiesByContinentsByCountry[continent][country ].Add(city);
			}

			foreach (var kvp in citiesByContinentsByCountry)
			{
				Console.WriteLine($"{kvp.Key}:");
				foreach (var country in citiesByContinentsByCountry[kvp.Key])
				{
					Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
				}
			}
		}
	}
}