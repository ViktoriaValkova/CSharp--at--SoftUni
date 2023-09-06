namespace P04.FastFood
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int foodQnt = int.Parse(Console.ReadLine());
			//int[] orders = Console.ReadLine()
			//	.Split()
			//	.Select(x=>int.Parse(x))
			//	.ToArray();

			//Queue<int> queue = new Queue<int>(orders);

			Queue<int> queue = new(
				Console.ReadLine()
					.Split(' ', StringSplitOptions.RemoveEmptyEntries)
					.Select(x => int.Parse(x)));

			Console.WriteLine(queue.Max());

			while (queue.Any())
			{
				foodQnt -= queue.Peek();
				if (foodQnt < 0)
				{
					break;
				}

				queue.Dequeue();
			}

			if (queue.Count > 0)
			{
				Console.WriteLine($"Orders left: {string.Join(' ', queue)}");
			}
			else
			{
				Console.WriteLine("Orders complete");
			}
		}
	}
}