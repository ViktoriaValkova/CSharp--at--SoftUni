namespace P03.CountUppercaseWords
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			Func<string, bool> startCapitalLetter = x =>x.Length>0 && char.IsUpper(x[0]);  // add length to be > 0 

			string[] filteredWords = input.Split(" ")
				.Where(startCapitalLetter)
				.ToArray();

			Console.WriteLine(string.Join("\n", filteredWords));
		}
	}
}