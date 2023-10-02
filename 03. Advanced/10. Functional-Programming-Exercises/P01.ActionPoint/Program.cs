namespace P01.ActionPoint
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Action<string> printer = x => Console.WriteLine(x);
			string[] input = Console.ReadLine()
				.Split()
				.ToArray();

			Array.ForEach(input, printer);
		}
	}
}