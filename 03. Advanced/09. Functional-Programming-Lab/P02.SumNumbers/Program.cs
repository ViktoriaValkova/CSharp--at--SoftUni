﻿namespace P02.SumNumbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input  = Console.ReadLine();

			Func< string,int> parser = x => int.Parse(x);

			int[] numbers = input.Split(", ")
				.Select(parser)
				.ToArray();

			Console.WriteLine(numbers.Length);
			Console.WriteLine(numbers.Sum());
		}
	}
}