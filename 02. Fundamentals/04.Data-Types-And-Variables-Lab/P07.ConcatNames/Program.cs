﻿namespace P07.ConcatNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimiter = Console.ReadLine();
            //Console.WriteLine($"{firstName}{delimiter}{secondName}");
            Console.WriteLine(firstName+delimiter+secondName);
        }
    }
}