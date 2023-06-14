using System;

namespace P02.AddBags         // 18/19.07.2020
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double priceLuggage = double.Parse(Console.ReadLine());
            double luggageKg = double.Parse(Console.ReadLine());
            int daysUntillTrip = int. Parse(Console.ReadLine());
            int luggageCount = int. Parse(Console.ReadLine());

            if (luggageKg < 10)
            {
                priceLuggage *= 0.2;
            }
            else if (luggageKg <= 20)
            {
                priceLuggage *= 0.5;
            }
            if (daysUntillTrip < 7)
            {
                priceLuggage *= 1.4;
            }
            else if (daysUntillTrip <= 30)
            {
                priceLuggage *= 1.15;
            }
            else
            {
                priceLuggage *= 1.1;
            }
            Console.WriteLine($"The total price of bags is: {priceLuggage*luggageCount:f2} lv. ");
        }
    }
}
