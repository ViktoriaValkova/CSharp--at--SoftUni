using System;
namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int videocardPrice = 250;
            double budget = double.Parse(Console.ReadLine());
            int videocardNumber = int.Parse(Console.ReadLine());
            int processorNumber = int.Parse(Console.ReadLine());
            int ramNumber = int.Parse(Console.ReadLine());
            double processorPrice = 0.35 * videocardPrice * videocardNumber;
            double ramPrice = 0.1 * videocardPrice * videocardNumber;
            double price = processorPrice * processorNumber + ramPrice * ramNumber + videocardPrice * videocardNumber;
            if (videocardNumber > processorNumber)
            {
                price = 0.85 * price;
                //price *=0.85;
            }
            if (price <= budget)
            {
                Console.WriteLine($"You have {(budget - price):f2} leva left!");
            }
            else
            { Console.WriteLine($"Not enough money! You need {Math.Abs(price - budget):f2} leva more!"); }
        }
    }
}