using System;

namespace P04.MovieStars   // 15/16.06.2019 // already done 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string nameActor = "";
            double actorSalary = 0;
            while ((nameActor = Console.ReadLine()) != "ACTION")
            {

                if (nameActor.Length > 15)
                {
                    actorSalary = budget * 0.2;
                    budget -= actorSalary;
                }
                else
                {
                    actorSalary = double.Parse(Console.ReadLine());
                    budget -= actorSalary;
                }
                if (budget < 0)
                {
                    break;
                }
            }
            if (budget < 0)
            {
                Console.WriteLine($"We need {Math.Abs(budget):f2} leva for our actors.");
            }
            else
            {
                Console.WriteLine($"We are left with {budget:f2} leva.");
            }
        }
    }
}
