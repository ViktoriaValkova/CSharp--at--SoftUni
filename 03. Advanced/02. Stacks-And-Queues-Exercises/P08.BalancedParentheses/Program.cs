namespace P08.BalancedParentheses
{
	internal class Program
	{
		static void Main(string[] args)
		{
			char[] parentheses = Console.ReadLine().ToCharArray();
			Stack<char> stack = new Stack<char>();
			bool notBalanced = false;

			for (int i = 0; i < parentheses.Length; i++)
			{

				if (parentheses[i] == '(' || parentheses[i] == '{' || parentheses[i] == '[')
				{
					stack.Push(parentheses[i]);
				}
				else if (parentheses[i] == ')')
				{
					if (stack.Count == 0 || stack.Pop() != '(')
					{
						notBalanced = true;
						break;
					}
				}
				else if (parentheses[i] == '}')
				{
					if (stack.Count == 0 || stack.Pop() != '{')
					{
						notBalanced = true;
						break;
					}
				}
				else if (parentheses[i] == ']')
				{
					if (stack.Count == 0 || stack.Pop() != '[')
					{
						notBalanced = true;
						break;
					}
				}
			}
			if (stack.Count > 0 || notBalanced)
			{
				Console.WriteLine("NO");
			}
			else
			{
				Console.WriteLine("YES");
			}
		}
	}
}