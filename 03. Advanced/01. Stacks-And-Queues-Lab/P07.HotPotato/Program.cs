namespace P07.HotPotato
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] players = Console.ReadLine().Split(' ');
			int count = int.Parse(Console.ReadLine());
			Queue<string> queue = new Queue<string>(players);
			while (queue.Count > 1)
			{
				for (int i = 0; i < count-1; i++)
				{
					string player = queue.Dequeue();
					queue.Enqueue(player);
				}

				Console.WriteLine($"Removed {queue.Dequeue()}");
			}

			Console.WriteLine($"Last is {queue.Dequeue()}");
		}
	}
}