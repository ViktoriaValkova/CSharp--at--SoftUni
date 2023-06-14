using System;

namespace P04.Club          // 06/07.07.2019
{

    internal class Program
    {
        static void Main(string[] args)
        {
            double goalIncome = double.Parse(Console.ReadLine());
            string coctailName = String.Empty;
            double income = 0;
            while ((coctailName = Console.ReadLine()) != "Party!")
            {


                int numberCocktails = int.Parse(Console.ReadLine());
                double price = coctailName.Length;
                double priceForOrder = price * numberCocktails;
                if (priceForOrder % 2 != 0)
                {
                    priceForOrder *= 0.75;
                }
                income += priceForOrder;
                if (income >= goalIncome)
                {
                    Console.WriteLine("Target acquired.");
                    break;
                }
            }
            if (coctailName == "Party!")
            {
                Console.WriteLine($"We need {goalIncome - income:f2} leva more.");
            }
            Console.WriteLine($"Club income - {income:f2} leva.");
        }
    }
}
