namespace P01.BasicStackOperations
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] cmd = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
			int[] numbers = Console.ReadLine().Split(' ').Select(x=>int.Parse(x)).ToArray();
			int countToPush = cmd[0];
			int countToPop = cmd[1];
			int numToFind = cmd[2];

			Stack<int> stack = new Stack<int>();

			for (int i = 0; i < countToPush; i++)
			{
				if (i < numbers.Length)
				{
					stack.Push(numbers[i]);
				}
			}

			for (int i = 0; i < countToPop; i++)
			{
				if (stack.Count > 0)
				{
					stack.Pop();
				}
			}

			if (stack.Count == 0)
			{
				Console.WriteLine(0);
				return;
			}

			if (stack.Contains(numToFind))
			{
				Console.WriteLine("true");
			}
			else
			{
				Console.WriteLine(stack.Min());
			}
		}
	}
}