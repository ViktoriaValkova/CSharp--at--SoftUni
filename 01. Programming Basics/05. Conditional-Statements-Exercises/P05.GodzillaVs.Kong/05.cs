using System;
namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine());
            double decorPrice = budget * 0.1;
            double clothesSumPrice = clothesPrice * peopleCount;
            if (peopleCount >= 150)
            {
                clothesSumPrice *= 0.9;
            }
            if (budget >= (clothesSumPrice + decorPrice))
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - clothesSumPrice - decorPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {decorPrice + clothesSumPrice - budget:f2} leva more.");
            }
        }
    }
}