using System;
namespace _03._New_Home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double flowerPrice = 0.0;
        if (flowerType == "Roses")
            {
                flowerPrice = 5.0;
                if (flowerCount > 80)
                {
                    flowerPrice *= .9; 
                }

            }
        if (flowerType == "Dahlias")
            {
                flowerPrice = 3.8;
                if (flowerCount > 90)
                {
                    flowerPrice *= .85;
                }

            }
        if (flowerType == "Tulips")
            {
                flowerPrice = 2.8;
                if (flowerCount > 80)
                {
                    flowerPrice *= .85;
                }

            }
        if (flowerType == "Narcissus")
            {
                flowerPrice = 3.0;
                if (flowerCount < 120)
                {
                    flowerPrice +=0.15*flowerPrice;
                }

            }
        if (flowerType == "Gladiolus")
            {
                flowerPrice = 2.50;
                if (flowerCount < 80)
                {
                    flowerPrice *= 1.2;
                }

            }
            double totalPrice = flowerPrice * flowerCount;
        if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {budget-totalPrice:f2} leva left."); 
            }
        else
            {
            Console.WriteLine($"Not enough money, you need {totalPrice-budget:f2} leva more.");
            }
        }
    }
}