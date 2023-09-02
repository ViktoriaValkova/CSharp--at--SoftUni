namespace P03.MaximumAndMinimumElement
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int cmdCount = int.Parse(Console.ReadLine());
			Stack<int> stack = new Stack<int>();
			for (int i = 0; i < cmdCount; i++)
			{
				int[] cmd = Console.ReadLine()
					.Split()
					.Select(int.Parse)
					.ToArray();

				switch (cmd[0])
				{
					case 1:
						stack.Push(cmd[1]);
						break;
					case 2:
						if (stack.Count > 0)
							stack.Pop();
						break;
					case 3:
						if (stack.Count > 0)
							Console.WriteLine(stack.Max());
						break;
					case 4:
						if (stack.Count > 0)
							Console.WriteLine(stack.Min());
						break;
				}
			}

			Console.WriteLine(string.Join(", ", stack));
		}
	}
}