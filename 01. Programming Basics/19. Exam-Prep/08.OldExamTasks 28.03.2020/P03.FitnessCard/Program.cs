using System;

namespace P03.FitnessCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double cardFee = 0;
            if (gender == 'm')
            {
                switch (sport)
                {
                    case "Gym": cardFee = 42; break;
                    case "Boxing": cardFee = 41; break;
                    case "Yoga": cardFee = 45; break;
                    case "Zumba": cardFee = 34; break;
                    case "Dances": cardFee = 51; break;
                    case "Pilates": cardFee = 39; break;
                }
            }
            else
            {
                switch (sport)
                {
                    case "Gym": cardFee = 35; break;
                    case "Boxing": cardFee = 37; break;
                    case "Yoga": cardFee = 42; break;
                    case "Zumba": cardFee = 31; break;
                    case "Dances": cardFee = 53; break;
                    case "Pilates": cardFee = 37; break;
                }
            }
            if (age <= 19)
            {
                cardFee *= 0.8;
            }
            if (cardFee <= budget)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${cardFee - budget:f2} more.");
            }
        }
    }
}
