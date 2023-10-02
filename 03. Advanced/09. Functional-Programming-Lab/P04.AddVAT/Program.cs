namespace P01.AddVAT
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			Func<decimal, decimal> addVat = x => x * 1.2m;
			Func<string, decimal> parser = x => decimal.Parse(x);
			Func<decimal, string> formater = x => $"{x:f2}";

			string[] prices = input.Split(", ")
				.Select(parser)
				.Select(addVat)
				.Select(formater)
				.ToArray();

			Console.WriteLine(string.Join("\n", prices));
		}
	}
}