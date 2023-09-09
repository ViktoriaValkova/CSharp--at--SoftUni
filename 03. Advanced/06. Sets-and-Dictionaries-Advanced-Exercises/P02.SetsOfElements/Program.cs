namespace P02.SetsOfElements
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] lengths = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
			int firstLength = lengths[0];
			int secondLength = lengths[1];
			Dictionary<double, int> nums = new Dictionary<double, int>();
			for (int i = 0; i < firstLength; i++)
			{
				double num = double.Parse(Console.ReadLine());
				if (!nums.ContainsKey(num))
				{
					    nums.Add(num, 0);
				}
			}
			for (int i = 0; i < secondLength; i++)
			{
				double num = double.Parse(Console.ReadLine());
				if (nums.ContainsKey(num))
				{
					nums[num]++;
				}
			}

			foreach (var kvp in nums)
			{
				if (kvp.Value > 0)
				{
					Console.Write($"{kvp.Key} ");
				}
			}
		}
	}
}