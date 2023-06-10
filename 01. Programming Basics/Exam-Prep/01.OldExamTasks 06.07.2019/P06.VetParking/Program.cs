using System;

namespace P06.VetParking    // 02/03.05.2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hoursEveryDay = int.Parse(Console.ReadLine());
            double price = 0;
            double pricePerDay = 0;
            double sumPrice = 0;
            for (int day = 1; day <= days; day++)
            {
                for (int hour = 1; hour <= hoursEveryDay; hour++)
                {
                    if ((day % 2 == 0) && (hour % 2 != 0))
                    {
                        price = 2.5;
                    }
                    else if ((day % 2 != 0) && (hour % 2 == 0))
                    {
                        price = 1.25;
                    }
                    else
                    {
                        price = 1.0;
                    }
                    pricePerDay += price;
                }
                Console.WriteLine($"Day: {day} - {pricePerDay:f2} leva");
                sumPrice += pricePerDay;
                pricePerDay = 0;
            }
            Console.WriteLine($"Total: {sumPrice:f2} leva");
        }
    }
}
