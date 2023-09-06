namespace P02.BasicQueueOperations
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] cmdArray = Console.ReadLine()
				.Split()
				.Select(x=>int.Parse(x))
				.ToArray();

			int[] numbers  = Console.ReadLine()
				.Split()
				.Select(x => int.Parse(x))
				.ToArray();

			int countToAdd = cmdArray[0];
			int countToRemove = cmdArray[1];
			int numToFind = cmdArray[2];

			Queue<int> queue = new Queue<int>();

			for (int i = 0; i < countToAdd; i++)
			{
				if (i < numbers.Length)
				{
					queue.Enqueue(numbers[i]);
				}
			}

			for (int i = 0; i < countToRemove; i++)
			{
				if (queue.Count > 0)
				{
					queue.Dequeue();
				}
			}
               
			if (queue.Count == 0)
			{
				Console.WriteLine(0);
			}
			else if (queue.Contains(numToFind))
			{
				Console.WriteLine("true");
			}
			else
			{
				Console.WriteLine(queue.Min());
			}

		}
	}
}