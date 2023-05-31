using System;
namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string region = "";
            string place = "";
            if (budget <= 100)
            {
                region = "Bulgaria";
               if (season == "summer")
                {
                    place = "Camp";
                    budget *= 0.30;
                }
               if (season == "winter")
                {
                    place = "Hotel";
                    budget *= 0.70;
                }
            }
            if (budget >100 && budget <= 1000)
            {
                region = "Balkans";
                if (season == "summer")
                {
                    place = "Camp";
                    budget *= 0.40;
                }
                if (season == "winter")
                {
                    place = "Hotel";
                    budget *= 0.80;
                }
            }
            if (budget > 1000)
            {
                region = "Europe";
                budget *= 0.90;
                place = "Hotel";
            }
            Console.WriteLine($"Somewhere in {region}");
            Console.WriteLine($"{place} - {budget:f2}");
        }
    }
}