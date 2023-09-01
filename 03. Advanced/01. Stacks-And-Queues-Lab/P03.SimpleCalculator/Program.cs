namespace P03.SimpleCalculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(' ').ToArray();
			Stack<string> stack = new Stack<string>();
			for (int i = 0; i < input.Length; i++)
			{
				stack.Push(input[i]);
			}
			int sum = 0;
			while (stack.Count > 1)
			{
				int currNum = int.Parse(stack.Pop());
				char ch = char.Parse(stack.Pop());
				if (ch == '+')
				{
					sum += currNum;
				}
				else
				{
					sum -= currNum;
				}
			}

			sum += int.Parse(stack.Pop());

			Console.WriteLine(sum);
		}
	}
}