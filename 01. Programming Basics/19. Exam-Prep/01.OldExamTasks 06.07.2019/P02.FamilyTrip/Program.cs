using System;

namespace P02.FamilyTrip  // 06/07.07.2019

{
    internal class Program
    {
        static void Main(string[] args)
        {
           double budget = double.Parse(Console.ReadLine());
            int daysCnt = int.Parse(Console.ReadLine());
            double pricePerDay = double.Parse(Console.ReadLine());
            int percentageExtras = int.Parse(Console.ReadLine());
            if (daysCnt > 7)
            {
                pricePerDay *= 0.95;
            }
            double priceSum = daysCnt * pricePerDay + (percentageExtras/100.0*budget);
            double difference = Math.Abs(budget - priceSum);
            if (priceSum <= budget) 
            {
                Console.WriteLine($"Ivanovi will be left with {difference:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{difference:f2} leva needed.");
            }
        }
    }
}
