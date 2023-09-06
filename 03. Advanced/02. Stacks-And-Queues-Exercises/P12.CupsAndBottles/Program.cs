namespace P012.CupsAndBottles
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Queue<int> cups = new(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)));

			Stack<int> bottles = new(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)));

			int wastedWater = 0;

			while (true)
			{
				if (!cups.Any() && bottles.Any())
				{
					Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
					break;
				}

				if (cups.Any() && !bottles.Any())
				{
					Console.WriteLine($"Cups: {string.Join(" ", cups)}");
					break;
				}

				int currentBottle = bottles.Pop();
				int currentCup = cups.Peek();

				while (currentCup >= 0)
				{
					if (currentBottle >= currentCup)
					{
						wastedWater += currentBottle - currentCup;
						cups.Dequeue();
						break;
					}
					currentCup -= currentBottle;
					currentBottle = bottles.Pop();
				}

			}

			Console.WriteLine($"Wasted litters of water: {wastedWater}");
		}
	}
}