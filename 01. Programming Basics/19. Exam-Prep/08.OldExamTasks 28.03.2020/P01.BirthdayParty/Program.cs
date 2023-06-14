using System;

namespace P01.BirthdayParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());
            double cakePrice = rent * 0.2;
            double drinks = cakePrice * 0.55;
            double animator = rent / 3.0;

            double budget = rent + cakePrice + drinks + animator;
            Console.WriteLine(budget);
        }
    }
}
