using System;

namespace P06.EasterCompetition     // 20/21.04.2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kozunakCount = int.Parse(Console.ReadLine());
            string chef = String.Empty;
            int pointsMax = 0;
            string bestChef = String.Empty;
            string input = String.Empty;
            for (int i = 0; i < kozunakCount; i++)
            {
                int points = 0;
                chef = Console.ReadLine();
                while ((input = Console.ReadLine()) != "Stop")
                {
                    points += int.Parse(input);

                }
                Console.WriteLine($"{chef} has {points} points.");
                if (points > pointsMax)
                {
                    pointsMax = points;
                    bestChef = chef;
                    Console.WriteLine($"{bestChef} is the new number 1!");
                }
            }
            Console.WriteLine($"{bestChef} won competition with {pointsMax} points!");
        }
    }
}
