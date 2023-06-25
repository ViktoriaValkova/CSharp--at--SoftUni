﻿namespace P08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int givenNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] + input[j] == givenNumber)
                    {
                        Console.Write($"{input[i]} {input[j]} ");
                        Console.WriteLine();
                    }

                }
            }
        }
    }
}