using System;
namespace P07.FuelTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            string fuelLowercase = fuelType.ToLower();
            double fuelAmmount = double.Parse(Console.ReadLine());
            if (fuelType == "Diesel" || fuelType == "Gasoline" || fuelType == "Gas")
            {
                if (fuelAmmount >= 25)
                {
                    Console.WriteLine($"You have enough {fuelLowercase}.");
                }
                else { Console.WriteLine($"Fill your tank with {fuelLowercase}!"); }
            }
            else { Console.WriteLine("Invalid fuel!"); }
        }
    }
}