using System;

namespace P06.EasterDecoration  // Exam 20/21.04.2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int customersCount = int.Parse(Console.ReadLine());
            string productType = "";
            double sumPrice = 0;
            int productCount = 0 ;
            double totalIncome = 0;
            for (int i = 1; i <= customersCount; i++)
            {
                while ((productType = Console.ReadLine()) != "Finish")
                {
                    productCount++;
                    switch (productType)
                    {
                        case "basket": sumPrice += 1.5;
                            break;
                        case "wreath": sumPrice += 3.8;
                            break;
                        case "chocolate bunny": sumPrice += 7.0;
                            break;
                    }
                }
                if (productCount % 2 == 0)
                {
                    sumPrice *= 0.8;
                }
                Console.WriteLine($"You purchased {productCount} items for {sumPrice:f2} leva.");            
                totalIncome += sumPrice;
                productCount = 0;
                sumPrice = 0;
            }
            Console.WriteLine($"Average bill per client is: {totalIncome/customersCount:f2} leva.");
        }
    }
}
