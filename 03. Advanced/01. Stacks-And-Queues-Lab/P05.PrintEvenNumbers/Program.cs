namespace P05.PrintEvenNumbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
			Queue<int> queue = new Queue<int>();

			for (int i = 0; i < input.Length; i++)
			{
				int currNum = input[i];
				if (currNum % 2 == 0)
				{
					queue.Enqueue(currNum);
				}
			}

			Console.WriteLine(string.Join(", ", queue));
		}
	}
}