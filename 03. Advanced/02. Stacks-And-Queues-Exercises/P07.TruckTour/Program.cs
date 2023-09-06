namespace P07.TruckTour
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int pumpsCount = int.Parse(Console.ReadLine());
			Queue<int[]> queue = new Queue<int[]>();
			for (int i = 0; i < pumpsCount; i++)
			{
				int[] pumpInfo = Console.ReadLine()
					.Split()
					.Select(x => int.Parse(x))
					.ToArray();

				queue.Enqueue(pumpInfo);
			}

			int index = 0;
			while (true)
			{
				int petrolAmnt = 0;
				foreach (var item in queue)
				{
					petrolAmnt += item[0];
					petrolAmnt -= item[1];

					if (petrolAmnt < 0)
					{
						queue.Enqueue(queue.Dequeue());
						index++;
						break;
					}

				}
				if (petrolAmnt >= 0)
				{
					Console.WriteLine(index);
					break;
				}
			}
		}
	}
}