
namespace P03.CustomMinFunction
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Func<int[], int> smallestNum = x => x.Min();

			int[] numbers = Console.ReadLine()
				.Split()
				.Select(x => int.Parse(x))
				.ToArray();

			Console.WriteLine(smallestNum(numbers));

		}


	}

}