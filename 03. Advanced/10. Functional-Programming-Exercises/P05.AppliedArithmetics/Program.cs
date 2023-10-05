using System.Security.Cryptography.X509Certificates;

namespace P05.AppliedArithmetics
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Func<int, int> multiply = (x) => x * 2;
			Func<int, int> addOne = (x) => x + 1;
			Func<int, int> subtract = x => x - 1;
			Action<int> print = x => Console.Write($"{x} ");

			int[] nums = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

			string cmd = string.Empty;

			while ((cmd = Console.ReadLine()) != "end")
			{
				switch (cmd)
				{
					case "add":
					nums =	nums.Select(addOne).ToArray();
						break;
					case "multiply": 
					nums = 	nums.Select(multiply).ToArray();
						break;
					case "subtract":
					nums =	nums.Select(subtract).ToArray();
						break;
					case "print":
						Array.ForEach(nums,print);
						Console.WriteLine();
						break;
				}
			}
		}
	}
}