﻿namespace P04.Froggy
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> stones = Console.ReadLine().Split(", ").Select(x=>int.Parse(x)).ToList();

			Lake lake = new Lake(stones);

			Console.WriteLine(string.Join(", ",lake));
		}
	}
}