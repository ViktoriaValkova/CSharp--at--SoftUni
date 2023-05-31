using System;
using System.Threading.Channels;

namespace P05.SmallShop
{
    internal class Program
    {
        static void Main(string[] args)    // Кристиян ги реши с If + If 
        {           
            string foodType = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine()); 
            double foodPrice = 0.0;
            switch (town)
            {
                case "Plovdiv":
                    switch (foodType)
                    {

                        case "coffee":foodPrice = 0.4;
                            break;
                        case "water":
                            foodPrice = 0.7;
                            break;
                        case "beer":
                            foodPrice = 1.15;
                            break;
                        case "sweets":
                            foodPrice = 1.3;
                            break;
                        case "peanuts":
                            foodPrice = 1.5;
                            break;
                    }
                    break;
                case "Sofia":
                    switch (foodType)
                    {

                        case "coffee":
                            foodPrice = 0.5;
                            break;
                        case "water":
                            foodPrice = 0.8;
                            break;
                        case "beer":
                            foodPrice = 1.20;
                            break;
                        case "sweets":
                            foodPrice = 1.45;
                            break;
                        case "peanuts":
                            foodPrice = 1.6;
                            break;
                    }
                    break; 
                case "Varna":
                    switch (foodType)
                    {

                        case "coffee":
                            foodPrice = 0.45;
                            break;
                        case "water":
                            foodPrice = 0.70;
                            break;
                        case "beer":
                            foodPrice = 1.10;
                            break;
                        case "sweets":
                            foodPrice = 1.35;
                            break;
                        case "peanuts":
                            foodPrice = 1.55;
                            break;
                    }
                    break;
            }
            double sum = (quantity * foodPrice);
            Console.WriteLine(sum);
        }
    }
}