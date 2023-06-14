using System;

namespace P01.AgencyProfit //   Exam - 18/19.07.20
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string airlineName = Console.ReadLine();
            int adultTicketsCount = int.Parse(Console.ReadLine());
            int kidTicketsCount = int.Parse(Console.ReadLine());
            double adultTicketPrice = double.Parse(Console.ReadLine());
            double agencyFee = double.Parse(Console.ReadLine());

            double kidTicketPrice = adultTicketPrice * 0.3;
            double agencyProfit = (adultTicketPrice * adultTicketsCount + kidTicketPrice * kidTicketsCount 
                + (adultTicketsCount + kidTicketsCount) * agencyFee) * 0.2;
            Console.WriteLine($"The profit of your agency from {airlineName} tickets is {agencyProfit:f2} lv.");
        }
    }
}
