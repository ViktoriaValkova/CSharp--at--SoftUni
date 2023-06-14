using System;

namespace P03.MovieDestination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double price = 0;
            if (season == "Winter")
            {
                switch (destination)
                {
                    case "Dubai": price = days * 45000 * 0.7; break;
                    case "Sofia": price = days * 17000 * 1.25; break;
                    case "London": price = days * 24000; break;
                }
            }
            else
            {
                switch (destination)
                {
                    case "Dubai": price = days * 40000 * 0.7; break;
                    case "Sofia": price = days * 12500 * 1.25; break;
                    case "London": price = days * 20250; break;
                }
            }
            if (price <= budget)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {budget - price:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {price - budget:f2} leva more!");
            }
        }
    }
}
