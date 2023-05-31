using System;
namespace P04.CarToGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string classCar = "";
            string typeCar = "";
            if (budget <= 100)
            {
                classCar = "Economy class";
                switch (season)
                {
                    case "Summer":
                        typeCar = "Cabrio"; budget *= 0.35;
                        break;
                    case "Winter":
                        typeCar = "Jeep"; budget *= 0.65;
                        break;
                }
            }
            else if (budget <= 500)
            {
                classCar = "Compact class";
                switch (season)
                {
                    case "Summer":
                        typeCar = "Cabrio"; budget *= 0.45;
                        break;
                    case "Winter":
                        typeCar = "Jeep"; budget *= 0.8;
                        break;
                }
            }
            else if (budget > 500)
            {
                classCar = "Luxury class";
                typeCar = "Jeep";
                budget *= 0.90;
            }
            Console.WriteLine(classCar);
            Console.WriteLine($"{typeCar} - {budget:f2}");
        }
    }
}