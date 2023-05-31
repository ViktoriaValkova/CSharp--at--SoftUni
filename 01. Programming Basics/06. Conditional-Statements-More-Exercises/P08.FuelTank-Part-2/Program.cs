using System;
namespace P08.FuelTank_Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string fuelType = Console.ReadLine();
            double fuelAmmount = double.Parse(Console.ReadLine());
            string discountCard = Console.ReadLine();
            double pricePerLiter = 0.0; //in leva per liter
            if (discountCard == "Yes")
            {
                switch (fuelType)
                {
                    case "Gas": pricePerLiter = 0.93-0.08; break;
                    case "Diesel": pricePerLiter = 2.33-0.12; break;
                    case "Gasoline": pricePerLiter = 2.22-0.18; break;
                }               
            }
            else
            {
                switch (fuelType)
                {
                    case "Gas": pricePerLiter = 0.93; break;
                    case "Diesel": pricePerLiter = 2.33; break;
                    case "Gasoline": pricePerLiter = 2.22; break;
                }
            }
            if (fuelAmmount >= 20 && fuelAmmount <= 25)
            {
                pricePerLiter *= 0.92; 
            }
            else if (fuelAmmount > 25)
            {
                pricePerLiter *= 0.90; 
            }
            Console.WriteLine($"{pricePerLiter * fuelAmmount:f2} lv.");
        }
    }
}