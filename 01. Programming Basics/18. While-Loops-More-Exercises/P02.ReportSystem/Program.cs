using System;

namespace P02.ReportSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumNeeded = int.Parse(Console.ReadLine());
            string input = "";
            int price = 0;
            int transactionCount = 0;
            int byCard = 0;
            int byCash = 0;
            int sumByCash = 0;
            int sumByCard = 0;
            while (sumNeeded > 0)
            {
                input = Console.ReadLine();
                if (input == "End")
                {
                    Console.WriteLine("Failed to collect required money for charity.");
                    break;
                }
                transactionCount++;
                price = int.Parse(input);
                if (transactionCount % 2 != 0)  // that is if its uneven trans., pay cash only
                {
                    if (price > 100) // not possible 
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else // possible 
                    {
                        byCash++;
                        sumByCash += price;
                        sumNeeded -= price;
                        Console.WriteLine("Product sold!");
                    }
                }
                else // even trans., pay card only
                {
                    if (price < 10) // not possible
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else  // possible
                    {
                        byCard++;
                        sumByCard += price;
                        sumNeeded -= price;
                        Console.WriteLine("Product sold!");
                    }
                }
            }
            if (input != "End")
            {
                Console.WriteLine($"Average CS: {(double)sumByCash / byCash:f2}");
                Console.WriteLine($"Average CC: {(double)sumByCard / byCard:f2}");
            }
        }
    }
}
