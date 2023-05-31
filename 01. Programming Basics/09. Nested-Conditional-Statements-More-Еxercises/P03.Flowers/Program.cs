using System;
namespace P03.Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numChrys = int.Parse(Console.ReadLine());
            int numRoses = int.Parse(Console.ReadLine());
            int numTulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char holiday = char.Parse(Console.ReadLine());
            double priceChrys = 0;
            double priceRoses = 0;
            double priceTulips = 0;
            if (season == "Spring" || season == "Summer")
            {
                priceChrys = 2.00;
                priceRoses = 4.10;
                priceTulips = 2.50;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                priceChrys = 3.75;
                priceRoses = 4.50;
                priceTulips = 4.15;
            }
            double price = priceChrys * numChrys + priceRoses * numRoses + priceTulips * numTulips;
            if (holiday == 'Y')
            {
                price *= 1.15;
            }
            if (numTulips > 7 && season == "Spring")
            {
                price *= 0.95;
            }
            if (numRoses >= 10 && season == "Winter")
            {
                price *= 0.90;
            }
            if (numTulips + numRoses + numChrys > 20)
            {
                price *= 0.80;
            }
; Console.WriteLine($"{price + 2:f2}");
        }
    }
}