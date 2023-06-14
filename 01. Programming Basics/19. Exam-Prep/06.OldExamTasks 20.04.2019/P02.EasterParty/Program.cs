using System;

namespace P02.EasterParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guestsCnt = int.Parse(Console.ReadLine());
            double pricePerPerson = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double cakePrice = budget * 0.1;
            if (guestsCnt >= 10 && guestsCnt <= 15)
            {
                pricePerPerson *= 0.85;
            }
            if (guestsCnt > 15 && guestsCnt <= 20)
            {
                pricePerPerson *= 0.8;
            }
            if (guestsCnt > 20)
            {
                pricePerPerson *= 0.75;
            }
            double finalPrice = pricePerPerson * guestsCnt + cakePrice;
            if (finalPrice <= budget)
            {
                Console.WriteLine($"It is party time! {budget - finalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {finalPrice - budget:f2} leva needed.");
            }
        }
    }
}
