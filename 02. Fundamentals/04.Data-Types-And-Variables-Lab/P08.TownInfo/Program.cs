﻿namespace P08.TownInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string town = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            short area = short.Parse(Console.ReadLine());
            Console.WriteLine($"Town {town} has population of {population} and area {area} square km.");
        }
    }
}