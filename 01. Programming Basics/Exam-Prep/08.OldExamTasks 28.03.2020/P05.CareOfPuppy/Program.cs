using System;

namespace P05.CareOfPuppy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodBought = int.Parse(Console.ReadLine()) * 1000;
            string command = string.Empty;
            int foodEaten = 0;
            while ((command = Console.ReadLine()) != "Adopted")
            {
                foodEaten = int.Parse(command);
                foodBought -= foodEaten;

            }
            if (foodBought < 0)
            {
                Console.WriteLine($"Food is not enough. You need {0-foodBought} grams more.");

            }
            else if (command == "Adopted")
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodBought} grams.");
            }
        }
    }
}
