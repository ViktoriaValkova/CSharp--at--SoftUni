using System;
namespace P05.Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());   
            double foodForDog = double.Parse(Console.ReadLine());
            double foodForCat = double.Parse(Console.ReadLine());
            double foodForTurtle = double.Parse(Console.ReadLine())/1000;
            double foodNeeded = (foodForCat + foodForDog + foodForTurtle)*days;
            if (foodNeeded <= foodLeft)
            {
                Console.WriteLine($"{Math.Floor(foodLeft - foodNeeded)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(foodNeeded - foodLeft)} more kilos of food are needed.");
            }
        }
    }
}