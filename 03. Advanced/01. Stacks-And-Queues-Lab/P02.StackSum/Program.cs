namespace P02.StackSum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			string cmd = string.Empty;
			Stack<int> stack = new Stack<int>(input);
			while ((cmd = Console.ReadLine().ToLower())!= "end")
			{
				string[] cmdArg = cmd.Split(" ");
				if (cmdArg[0] == "add")
				{
					int firstNum = int.Parse(cmdArg[1]);
					int secondNum = int.Parse(cmdArg[2]);
					stack.Push(firstNum);
					stack.Push(secondNum);
				}
				else if (cmdArg[0] == "remove")
				{
					int count = int.Parse(cmdArg[1]);
					if (count <= stack.Count)
					{
						for (int i = 0; i < count; i++)
						{
						stack.Pop();
						}
					}
				}
			}

			Console.WriteLine($"Sum: {stack.Sum()}");
		}
	}
}