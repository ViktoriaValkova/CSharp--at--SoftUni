using Microsoft.VisualBasic;
using System;

namespace P02.Safari         // 02/02.05.2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double fuelNeeded = double.Parse(Console.ReadLine()); //price = 2.1 per Liter\
            string dayOfTrip = Console.ReadLine(); // "Saturday" or "Sunday"

            double price = fuelNeeded * 2.1 + 100; 
            if (dayOfTrip == "Saturday")
            {
                price *= 0.9;
            }
            else
            {
                price *= 0.8;
            }
            double difference = Math.Abs(price - budget);
            if (price > budget)
            {
                Console.WriteLine($"Not enough money! Money needed: {difference:f2} lv.");
            }
            else
            {
                Console.WriteLine($"Safari time! Money left: {difference:f2} lv. ");
            }
        }
    }
}
