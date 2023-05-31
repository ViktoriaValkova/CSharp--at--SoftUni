using System;
namespace P01.MatchTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numberPeople = int.Parse(Console.ReadLine());
            double transportMoney = 0;
            double ticketPrice = 0;
            double moneyNeeded = 0; 
            if (numberPeople <= 4)
            {
                transportMoney = budget * 0.75;
            }
            else if (numberPeople <= 9)
            {
                transportMoney = budget * 0.6;
            }
            else if (numberPeople <= 24)
            {
                transportMoney = budget * 0.5;      
            }
            else if (numberPeople <= 49)
            {
                transportMoney = budget * 0.4;
            }
            else
            {
                transportMoney = budget * 0.25;
            }
            if (category == "VIP")
            {
                ticketPrice = 499.99;
            }
            else
            {
                ticketPrice = 249.99;
            }
            moneyNeeded = ticketPrice * numberPeople + transportMoney;
            if (budget >= moneyNeeded)
            {
                Console.WriteLine($"Yes! You have {budget - moneyNeeded:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {moneyNeeded - budget:f2} leva.");
            }
        }
    }
}