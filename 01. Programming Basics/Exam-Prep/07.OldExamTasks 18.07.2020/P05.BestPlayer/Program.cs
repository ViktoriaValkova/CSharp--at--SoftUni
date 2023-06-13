using System;

namespace P05.BestPlayer           // 18/19.07.2020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName = String.Empty;
            int goals = 0;
            int maxGoals = 0;
            string bestPlayer = String.Empty;
            bool hatTrick = false;
            int bestPlayerGoals = 0;
            while ((playerName = Console.ReadLine()) != "END")
            {
                goals = int.Parse(Console.ReadLine());
                if (goals > maxGoals)
                {
                    maxGoals = goals;
                    bestPlayer = playerName;
                    bestPlayerGoals = goals;
                }
                if (goals >= 3)
                {
                    hatTrick = true;
                }
                if (goals >= 10)
                {
                    break;
                }
            }
            Console.WriteLine($"{bestPlayer} is the best player!");
            if (hatTrick)
            {
                Console.WriteLine($"He has scored {bestPlayerGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {bestPlayerGoals} goals.");
            }
        }
    }
}
