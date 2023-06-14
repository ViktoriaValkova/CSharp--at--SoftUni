using System;

namespace P03.TravelAgency         //  06/07.07.2019
{
    internal class Program              /// better without return 
    {
        static void Main(string[] args)
        {
           string town = Console.ReadLine(); // "Bansko",  "Borovets", "Varna"  "Burgas"
            string packageType = Console.ReadLine(); // "noEquipment",  "withEquipment", "noBreakfast"  "withBreakfast"
            string vip = Console.ReadLine(); // yes or no 
            int days = int.Parse(Console.ReadLine());
            double pricePerDay = 0; 

            if (days <= 0)
            {
                Console.WriteLine("Days must be positive number!");
                return;
            }
            if (town == "Bansko" || town == "Borovets")
            {
                if (packageType == "withEquipment")
                {
                    pricePerDay = 100;
                    if (vip == "yes")
                    {
                        pricePerDay *= 0.9;
                    }
                }
                else if (packageType == "noEquipment")
                {
                    pricePerDay = 80;
                    if (vip == "yes")
                    {
                        pricePerDay *= 0.95;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    return;
                }
            }
            else if (town == "Varna" || town == "Burgas")
            {
                if (packageType == "withBreakfast")
                {
                    pricePerDay = 130;
                    if (vip == "yes")
                    {
                        pricePerDay *= 0.88;
                    }
                }
                else if (packageType == "noBreakfast")
                {
                    pricePerDay = 100;
                    if (vip == "yes")
                    {
                        pricePerDay *= 0.93;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            double finalPrice = pricePerDay * days;
            if (days > 7)
            {
                finalPrice -= pricePerDay;
            }
            Console.WriteLine($"The price is {finalPrice:f2}lv! Have a nice time!");
        }
    }
}
