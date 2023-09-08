namespace P01.CountSameValuesInArray
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<double, int> numsByCount = new Dictionary<double, int>();

			double[] nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
				.Select(x => double.Parse(x)).ToArray();

			foreach (double num in nums)
			{
				if (!numsByCount.ContainsKey(num))
				{
					numsByCount.Add(num,0);
				}

				numsByCount[num]++;
			}

			foreach (var kvp in numsByCount)
			{
				Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
			}
		}
	}
}