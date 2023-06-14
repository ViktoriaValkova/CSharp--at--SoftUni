using System;

namespace P03.EnergyBooster      // 28/29.03.2020
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string fruit = Console.ReadLine();
            string setSize = Console.ReadLine();
            int setCount = int.Parse(Console.ReadLine());
            double pricePerSet = 0;
            double finalPrice = 0;
            if (setSize == "small")
            {
                switch (fruit)
                {
                    case "Watermelon": pricePerSet = 56.0*2;
                        break;
                    case "Mango":
                        pricePerSet = 36.66*2;
                        break;
                    case "Pineapple":
                        pricePerSet = 42.1 * 2;
                        break;
                    case "Raspberry":
                        pricePerSet = 20.0 * 2;
                        break;
                }
            }
            else
            {
                switch (fruit)
                {
                    case "Watermelon":
                        pricePerSet = 28.7*5;
                        break;
                    case "Mango":
                        pricePerSet = 19.60*5;
                        break;
                    case "Pineapple":
                        pricePerSet = 24.8*5;
                        break;
                    case "Raspberry":
                        pricePerSet = 15.2*5;
                        break;
                }
            }
            finalPrice = pricePerSet * setCount;
            if (finalPrice >= 400 && finalPrice <= 1000)
            {
                finalPrice *= 0.85;
            }
            if (finalPrice > 1000)
            {
                finalPrice *= 0.5;
            }
            Console.WriteLine($"{finalPrice:f2} lv.");
        }
    }
}
