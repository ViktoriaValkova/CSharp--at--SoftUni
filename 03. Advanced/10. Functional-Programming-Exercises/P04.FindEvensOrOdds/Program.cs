namespace P04.FindEvensOrOdds
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Func<int, int, List<int>> generateRange = (start, end) =>
			{
				List<int> range = new List<int>();

				for (int i = start; i <= end; i++)
				{
					range.Add(i);
				}

				return range;
			};

			Predicate<int> isOdd = x => x % 2 !=0;
			Predicate<int> isEven = x => x % 2 == 0;

			int[] boundaries = Console.ReadLine().Split().Select(x=>int.Parse(x)).ToArray();

			string cmd = Console.ReadLine();

			List<int> numbers = generateRange(boundaries[0], boundaries[1]);

			List<int> result = new();
			
			foreach (var number in numbers)
			{
				if (cmd == "even" && isEven(number))
				{
					result.Add(number);
				}
				else if (cmd == "odd" && isOdd(number))
				{
					result.Add(number);
				}
			}

			Console.WriteLine(string.Join(" ", result));
		}
	}
}