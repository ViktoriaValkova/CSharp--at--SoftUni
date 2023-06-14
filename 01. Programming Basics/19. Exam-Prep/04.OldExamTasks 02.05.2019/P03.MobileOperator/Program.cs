using System;

namespace P03.MobileOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contractDuration = Console.ReadLine();
            string contractType = Console.ReadLine();
            string internet = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());
            double pricePerMonth = 0; 
            if (contractDuration == "one")
            {
                switch (contractType)
                {
                    case "Small": pricePerMonth = 9.98; break;
                    case "Middle": pricePerMonth = 18.99; break;
                    case "Large": pricePerMonth = 25.98; break;
                    case "ExtraLarge": pricePerMonth = 35.99; break; 
                }
            }
            else
            {
                switch (contractType)
                {
                    case "Small": pricePerMonth = 8.58; break;
                    case "Middle": pricePerMonth = 17.09; break;
                    case "Large": pricePerMonth = 23.59; break;
                    case "ExtraLarge": pricePerMonth = 31.79; break;
                }
            }
            if (internet == "yes")
            {
                if (pricePerMonth <= 10.00)
                {
                    pricePerMonth += 5.5;
                }
                else if (pricePerMonth <= 30.00)
                {
                    pricePerMonth += 4.35;
                }
                else if (pricePerMonth > 30.00)
                {
                    pricePerMonth += 3.85;
                }
            }
            double finalPrice = pricePerMonth * months;
            if (contractDuration == "two")
            {
                finalPrice *= 0.9625;
            }
            Console.WriteLine($"{finalPrice:f2} lv.");
        }
    }
}
