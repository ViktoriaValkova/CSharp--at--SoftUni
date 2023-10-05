
namespace P06.Reverse_and_Exclude
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Func<string, int> parser = x => int.Parse(x);

			string input = Console.ReadLine();
			int n = int.Parse(Console.ReadLine());

			Predicate<int> isDivisible = x => x % n != 0; 

			int[] nums = input
				.Split()
				.Select(parser)
				.Where(x=> isDivisible(x))
				.Reverse()
				.ToArray();

			Console.WriteLine(string.Join(" ", nums));
		}
	}
}