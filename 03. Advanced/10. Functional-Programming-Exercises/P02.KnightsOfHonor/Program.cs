namespace P02.KnightsOfHonor
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Action<string> addSir = x => Console.WriteLine($"Sir {x}");

			string[] input = Console.ReadLine()
				.Split()
				.ToArray();

			Array.ForEach(input,addSir);
		}
	}
}