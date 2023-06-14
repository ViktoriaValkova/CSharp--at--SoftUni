using System;

namespace P05.SuitcasesLoad    // 28/29.03.2020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double truckCapacity = double.Parse(Console.ReadLine());
            string input = String.Empty;
            double sumLuggageLoad = 0;
            int luggageCount = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                double luggageVolume = double.Parse(input);


 luggageCount++;
                if (luggageCount % 3 == 0)   // posibly before the above check, because what if normal vol fits, but 1.1 doesnt;
                {
                    sumLuggageLoad += luggageVolume * 1.1;
                }
                else
                {
                    sumLuggageLoad += luggageVolume;
                }
                if (sumLuggageLoad > truckCapacity)
                {
                    Console.WriteLine("No more space!");
                    luggageCount--;
                    break;
                }
               
            }
            if (input == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            Console.WriteLine($"Statistic: {luggageCount} suitcases loaded.");
        }
    }
}
