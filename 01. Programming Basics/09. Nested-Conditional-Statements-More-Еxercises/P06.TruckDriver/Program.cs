using System;
namespace P06.TruckDriver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kilometers = double.Parse(Console.ReadLine());
            double income = 0;
            double incomePerKm = 0;
            if (kilometers <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        incomePerKm = 0.75;
                        break;
                    case "Summer":
                        incomePerKm = 0.90;
                        break;
                    case "Winter":
                        incomePerKm = 1.05;
                        break;
                }
            }
            else if (kilometers <= 10_000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        incomePerKm = 0.95;
                        break;
                    case "Summer":
                        incomePerKm = 1.10;
                        break;
                    case "Winter":
                        incomePerKm = 1.25;
                        break;
                }
            }
            else if (kilometers <= 20_000)
            {
                incomePerKm = 1.45;
            }
            income = incomePerKm * kilometers * 4 * 0.9;  //months per season + taxes
            Console.WriteLine($"{income:f2}");
        }
    }
}