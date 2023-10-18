namespace P03.Stack
{
	public class Program
	{
		static void Main(string[] args)
		{

			string input = string.Empty;
			MyStack<int> myStack = new MyStack<int>();
			while ((input = Console.ReadLine()) != "END")
			{
				string[] cmdArg = input.Split(" ",2).ToArray();

				switch (cmdArg[0])
				{
					case "Push": 
						int[] nums = cmdArg[1].Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToArray();
						myStack.Push(nums);
						break;
					case "Pop":
						try
						{
							myStack.Pop();
						}
						catch (Exception ex) 
						{
							Console.WriteLine(ex.Message);
						}
						break;
				}
			}

			foreach (int num in myStack)
			{
				Console.WriteLine(num);
			}
			foreach (int num in myStack)
			{
				Console.WriteLine(num);
			}
		}
	}
}