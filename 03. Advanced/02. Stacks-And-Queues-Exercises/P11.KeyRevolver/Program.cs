using System.Threading.Channels;

namespace P011.KeyRevolver
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int bulletPrice = int.Parse(Console.ReadLine());
			int barrelSize = int.Parse(Console.ReadLine());
			int[] bullets = Console.ReadLine()
				.Split(' ', StringSplitOptions.RemoveEmptyEntries)
				.Select(x => int.Parse(x))
				.ToArray();

			int[] locks = Console.ReadLine()
				.Split(' ', StringSplitOptions.RemoveEmptyEntries)
				.Select(x => int.Parse(x))
				.ToArray();

			int value = int.Parse(Console.ReadLine());
			int bulletsCost = 0;
			Queue<int> locksQueue = new Queue<int>(locks);
			Stack<int> bulletStack = new Stack<int>(bullets);

			int shotsCount = 0;
			while (locksQueue.Any())
			{

				if (bulletStack.Pop() <= locksQueue.Peek())
				{
					Console.WriteLine("Bang!");
					locksQueue.Dequeue();
				}
				else
				{
					Console.WriteLine("Ping!");
				}
				bulletsCost += bulletPrice;
				shotsCount++;
				if (!bulletStack.Any() && locksQueue.Count>0)
				{
					Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
					return;
				}
				if (shotsCount == barrelSize && (locksQueue.Count > 0 || bulletStack.Count>0))
				{
					Console.WriteLine("Reloading!");
					shotsCount = 0;
				}
			}

			Console.WriteLine($"{bulletStack.Count} bullets left. Earned ${value - bulletsCost}");
		}
	}
}