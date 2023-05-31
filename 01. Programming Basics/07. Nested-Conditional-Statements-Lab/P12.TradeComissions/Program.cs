using System;
namespace P12.TradeComissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse (Console.ReadLine());
            double percentage = 0.0; 
            if (sales >= 0 && sales <= 500)
            {
                switch (town)
                {
                    case "Sofia":
                        percentage = 0.05;
                        break;
                    case "Varna":
                        percentage = 0.045 ;
                        break;
                    case "Plovdiv":
                        percentage = 0.055;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }          
            }
            else if (sales > 500 && sales <= 1000)
            {
                switch (town)
                {
                    case "Sofia":
                        percentage =0.07;
                        break;
                    case "Varna":
                        percentage = 0.075;
                        break;
                    case "Plovdiv":
                        percentage = 0.08;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sales > 1000 && sales < 10000)
            {
                switch (town)
                {
                    case "Sofia":
                        percentage = 0.08;
                        break;
                    case "Varna":
                        percentage = 0.10;
                        break;
                    case "Plovdiv":
                        percentage = 0.12;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sales >= 10000)
            {
                switch (town)
                {
                    case "Sofia":
                        percentage = 0.12;
                        break;
                    case "Varna":
                        percentage = 0.13;
                        break;
                    case "Plovdiv":
                        percentage = 0.145;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            if (percentage > 0)
            {
                double commission = sales * percentage;
                Console.WriteLine($"{commission:f2}");
            }
        }
    }
}