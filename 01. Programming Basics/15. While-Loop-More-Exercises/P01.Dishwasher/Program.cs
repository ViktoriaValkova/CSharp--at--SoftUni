using System;

namespace P01.Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dishSoap = int.Parse(Console.ReadLine()) * 750;
            int plateCount = 0;
            int potCount = 0;
            string input;
            int loadCount = 0;
            while ((input = Console.ReadLine()) != "End")
            {
                loadCount++;

                if (loadCount % 3 != 0) // that is, if its not the third load
                {
                    plateCount += int.Parse(input);
                    dishSoap -= int.Parse(input) * 5;
                }
                else // that is, if its the third load
                {
                    potCount += int.Parse(input);
                    dishSoap -= int.Parse(input) * 15;
                }
                if (dishSoap < 0)
                {
                    break;
                }
            }
            if (dishSoap >= 0)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{plateCount} dishes and {potCount} pots were washed.");
                Console.WriteLine($"Leftover detergent {dishSoap} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(dishSoap)} ml. more necessary!");
            }
        }
    }
}
