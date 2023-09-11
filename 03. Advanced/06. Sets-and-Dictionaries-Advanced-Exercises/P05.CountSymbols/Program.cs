using System.Collections.Specialized;

namespace P05.CountSymbols
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			SortedDictionary<char, int> charsByCount = new SortedDictionary<char, int>();

			foreach (char ch in input)
			{
				if (!charsByCount.ContainsKey(ch))
				{
					charsByCount.Add(ch, 0);
				}
				charsByCount[ch]++;
			}

			foreach (var kvp in charsByCount)
			{
				Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
			}
		}
	}
}