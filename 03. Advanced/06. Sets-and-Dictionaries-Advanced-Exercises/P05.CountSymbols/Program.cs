namespace P05.CountSymbols
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			Dictionary<char, int> charsByCount = new Dictionary<char, int>();

			foreach (char ch in input)
			{
				if (!charsByCount.ContainsKey(ch))
				{
					charsByCount.Add(ch, 0);
				}
				charsByCount[ch]++;
			}

			foreach (var kvp in charsByCount.OrderBy(x=>x.Key))
			{
				Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
			}
		}
	}
}