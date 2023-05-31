using System;
namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermenCount = int.Parse(Console.ReadLine());
            double rent = 0.0;
            if (season == "Spring")
            {
                rent = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                rent = 4200;

            }
            else if (season == "Winter")
            {
                rent = 2600;
            }
            if (fishermenCount <= 6)
            {
                rent *= 0.9; 
            }
            if (fishermenCount > 7 && fishermenCount <= 11)
            {
                rent *= 0.85;
            }
            if (fishermenCount > 12)
            {
                rent *= 0.75;
            }
            if (season == "Spring" || season == "Summer" || season =="Winter")
            {
                if (fishermenCount % 2 == 0) 
                {
                    rent *= 0.95;
                }
            }
            if (budget >= rent)
            {
                Console.WriteLine($"Yes! You have {budget-rent:f2} leva left.");
            }
            if (budget < rent)
            {
                Console.WriteLine($"Not enough money! You need {rent - budget:f2} leva.");
            }
        }
    }
}