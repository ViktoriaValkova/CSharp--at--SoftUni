using System;

namespace P04.FoodForPets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double sumFood = double.Parse(Console.ReadLine());
            int foodForDog = 0;
            int foodForCat = 0;
            double biscuits = 0;
            for (int i = 1; i <= days; i++)
            {
                int currentFoodForDog = int.Parse(Console.ReadLine());
                int currenFoodForCat = int.Parse(Console.ReadLine());
                foodForDog += currentFoodForDog;
                foodForCat += currenFoodForCat;
                if (i % 3 == 0)
                {
                    biscuits += (currenFoodForCat + currentFoodForDog) * 0.1;
                }
            }
            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{(foodForCat + foodForDog) / sumFood * 100:f2}% of the food has been eaten.");
            Console.WriteLine($"{(double)foodForDog / (foodForCat + foodForDog) * 100:f2}% eaten from the dog.");
            Console.WriteLine($"{(double)foodForCat / (foodForCat + foodForDog) * 100:f2}% eaten from the cat.");


        }
    }
}
