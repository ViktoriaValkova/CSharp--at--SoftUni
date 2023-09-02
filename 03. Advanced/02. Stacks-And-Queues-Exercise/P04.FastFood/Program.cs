namespace P04.FastFood
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int foodQnt = int.Parse(Console.ReadLine());
			int[] orders = Console.ReadLine()
				.Split()
				.Select(x=>int.Parse(x))
				.ToArray();

			Queue<int> queue = new Queue<int>(orders);

			Console.WriteLine(queue.Max());

			while (queue.Count > 0 ) 
			{
				int currentOrder = queue.Peek();
				if (currentOrder <= foodQnt)
				{
					queue.Dequeue();
					foodQnt-= currentOrder;
				}
				else
				{
					break;
				}
			}
               
			if (queue.Count > 0)
			{
				Console.WriteLine($"Orders left: {string.Join(' ',queue )}");
			}
			else
			{
				Console.WriteLine("Orders complete");
			}
		}
	}
}