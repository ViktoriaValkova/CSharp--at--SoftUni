using System;

namespace P03.Gymnastics    // 09/10.03.2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string country = Console.ReadLine(); // ("Russia", "Bulgaria" или "Italy")
            string discipline = Console.ReadLine(); // ("ribbon", "hoop" или "rope")
            double sumRating = 0;
            
            if (country == "Russia")
            {
                switch (discipline)
                {
                    case "ribbon": sumRating = 9.1 + 9.4;
                        break;
                    case "hoop":
                        sumRating = 9.3+ 9.8;
                        break;
                    case "rope":
                        sumRating = 9.6+9;
                        break;
                }
            }
            else if (country == "Bulgaria")
            {
                switch (discipline)
                {
                    case "ribbon":
                        sumRating = 9.6 + 9.4;
                        break;
                    case "hoop":
                        sumRating = 9.55+9.75;
                        break;
                    case "rope":
                        sumRating = 9.5+9.4;
                        break;
                }
            }
            else
            {
                switch (discipline)
                {
                    case "ribbon":
                        sumRating = 9.2+9.5;
                        break;
                    case "hoop":
                        sumRating = 9.45+9.35;
                        break;
                    case "rope":
                        sumRating = 9.7+ 9.15;
                        break;
                }
            }
            double percentageLeftToMax = (20 - sumRating) / 20 * 100;
            Console.WriteLine($"The team of {country} get {sumRating:f3} on {discipline}.");
            Console.WriteLine($"{percentageLeftToMax:f2}%");
        }
    }
}
