namespace P01.ReverseAString
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			Stack<char> stack = new Stack<char> (input);

			for (int i = 0; i < input.Length; i++)
			{
				Console.Write(stack.Pop());
			}
               
		}
	}
}