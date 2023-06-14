using System;

namespace P01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int percentageFats = int.Parse(Console.ReadLine());
            int percentageProtein = int.Parse(Console.ReadLine());
            int percentageCarbs = int.Parse(Console.ReadLine());
            int sumCalories = int.Parse(Console.ReadLine());
            double percenageWater = int.Parse(Console.ReadLine());
            double gramFats = (percentageFats/100.0* sumCalories) / 9;
            double gramProtein = (percentageProtein/100.0*sumCalories) / 4;
            double gramCarbs = (percentageCarbs / 100.0 * sumCalories) / 4;
            double sumGrams = (gramFats + gramCarbs + gramProtein);
            double caloriesPerGram = sumCalories * 1.0 / sumGrams;
            caloriesPerGram -= caloriesPerGram * (percenageWater / 100.0);
            Console.WriteLine($"{caloriesPerGram:f4}");
        }
    }
}
