using System;

namespace P08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournamentsCount = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            int sumPoints = startingPoints;
            int sumWins = 0;
            for (int i = 1; i <= tournamentsCount; i++)
            {
                string phase = Console.ReadLine();
                switch (phase)
                {
                    case "W": sumPoints += 2000;
                        sumWins++;
                        break;
                    case "F": sumPoints += 1200;
                        break;
                    case "SF":sumPoints += 720;
                        break;
                }
            }
            Console.WriteLine($"Final points: {sumPoints}");  
            Console.WriteLine($"Average points: {Math.Floor((sumPoints - startingPoints) / (double)tournamentsCount)}"); 
            // instead of declaring it as double, we can simply multiply by 1.0;
            Console.WriteLine($"{sumWins / (double)tournamentsCount * 100:f2}%");
        }
    }
}
