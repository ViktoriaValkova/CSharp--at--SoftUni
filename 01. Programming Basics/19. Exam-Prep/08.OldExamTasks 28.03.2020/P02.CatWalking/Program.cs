using System;

namespace P02.CatWalking     //  28/29.03.2020
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int minutesWalking = int.Parse(Console.ReadLine());  
            int walkCount = int.Parse(Console.ReadLine());
            int caloriesIn = int.Parse(Console.ReadLine());

            double caloriesOut = minutesWalking * walkCount * 5.0;
            if (caloriesOut*2.0 >= caloriesIn) 
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloriesOut}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloriesOut}.");
            }

        }
    }
}
