using System;
namespace P11.FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruitType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double fruitPrice = 0.0;
        switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruitType)
                    {
                        case "banana":
                            fruitPrice = 2.5;
                            break;
                        case "apple":
                            fruitPrice= 1.2 ;
                            break;
                        case "orange":
                            fruitPrice =0.85 ;
                            break;
                        case "grapefruit":
                            fruitPrice =1.45 ;
                            break;
                        case "kiwi":
                            fruitPrice = 2.7;
                            break;
                        case "pineapple":
                            fruitPrice =5.5 ;
                            break;
                        case "grapes":
                            fruitPrice = 3.85;
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                    break;

                case "Saturday":
                case "Sunday":
                    switch (fruitType)
                    {
                        case "banana":
                            fruitPrice = 2.7;
                            break;
                        case "apple":
                            fruitPrice =1.25 ;
                            break;
                        case "orange":
                            fruitPrice = 0.9;
                            break;
                        case "grapefruit":
                            fruitPrice =1.6;
                            break;
                        case "kiwi":
                            fruitPrice = 3.0;
                            break;
                        case "pineapple":
                            fruitPrice =5.6 ;
                            break;
                        case "grapes":
                            fruitPrice = 4.2;
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            if (fruitPrice > 0)
            {
                double sum = fruitPrice*quantity;
                Console.WriteLine($"{sum:f2}");
            }                       
        }
    }
}