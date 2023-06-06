using System;

namespace P05.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int tournamentCount = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            int points = startingPoints;
            int winCount = 0;

            for (int i  = 0;  i < tournamentCount; i++)
            {
               string tournamentStage = Console.ReadLine();
                switch (tournamentStage)
                {
                    case "W": points += 2000;
                        winCount++;
                        break;
                    case "F": points += 1200;
                        break;
                    case "SF": points += 720;
                        break;
                }
            }
            double average = Math.Floor((points - startingPoints)*1.0 / tournamentCount);
            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {average}");
            Console.WriteLine($"{(double)winCount/ tournamentCount*100:f2}%");
        }
    }
}
