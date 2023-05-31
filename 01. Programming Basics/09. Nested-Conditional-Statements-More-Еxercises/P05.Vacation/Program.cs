using System;
namespace P05.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string housing = "";
            string location = "";
            if (budget <= 1000)
            {
                housing = "Camp";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska"; budget *= 0.65;
                        break;
                    case "Winter":
                        location = "Morocco"; budget *= 0.45;
                        break;
                }
            }
            else if (budget <= 3000)
            {
                housing = "Hut";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska"; budget *= 0.8;
                        break;
                    case "Winter":
                        location = "Morocco"; budget *= 0.6;
                        break;
                }
            }
            else if (budget > 3000)
            {
                housing = "Hotel";
                budget *= 0.9;
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        break;
                    case "Winter":
                        location = "Morocco";
                        break;
                }
            }
            Console.WriteLine($"{location} - {housing} - {budget:f2}");
        }
    }
}