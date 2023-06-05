using System;

namespace P03.CoffeeMachine     // 06/07.07.2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drinkType = Console.ReadLine();
            string sugar = Console.ReadLine();
            int drinksCount = int.Parse(Console.ReadLine());
            double drinkPrice = 0;
          

            if (sugar == "Without")
            {
                switch (drinkType)
                {
                    case "Espresso": drinkPrice = 0.9;
                        break;
                    case "Cappuccino": drinkPrice = 1.0;
                        break;
                    case "Tea": drinkPrice = 0.5;
                        break;
                }
                
                drinkPrice*= 0.65;
            }
            else if (sugar == "Normal")
            {
                switch (drinkType)
                {
                    case "Espresso": drinkPrice = 1.0;
                        break;
                    case "Cappuccino": drinkPrice = 1.2;
                        break;
                    case "Tea": drinkPrice = 0.6;
                        break;
                }
            }
            else
            {
                switch (drinkType)
                {
                    case "Espresso": drinkPrice = 1.2;
                        break;
                    case "Cappuccino": drinkPrice = 1.6;
                        break;
                    case "Tea": drinkPrice = 0.7;
                        break;
                }
            }
            double sumPrice = drinkPrice * drinksCount;
            if (drinkType == "Espresso" && drinksCount >= 5)
            {
                sumPrice *=0.75;
            }
            if (sumPrice > 15.0)
            {
                sumPrice *= 0.8;
            }
            Console.WriteLine($"You bought {drinksCount} cups of {drinkType} for {sumPrice:f2} lv.");
        }
    }
}
