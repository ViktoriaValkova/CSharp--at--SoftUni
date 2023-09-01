﻿using System.Linq.Expressions;

namespace P04.MatchingBrackets
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			Stack<int> stack = new Stack<int>();
	
			
			for (int i = 0; i < input.Length; i++)
			{
				char ch = input[i];
				if (ch == '(')
				{
					stack.Push(i);
				}
				else if (ch == ')')
				{
					int startIndex = stack.Pop();
					int endIndex = i; 
					string currExpression = input.Substring(startIndex, endIndex - startIndex +1);
				Console.WriteLine(currExpression);
				}

			}
               
			
		}
	}
}