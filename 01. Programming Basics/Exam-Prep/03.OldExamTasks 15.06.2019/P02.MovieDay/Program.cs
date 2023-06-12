using System;

namespace P02.MovieDay // 15/16.06.2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int timeForShooting = int.Parse(Console.ReadLine());
            int scenesNum = int.Parse(Console.ReadLine());
            int sceneLength = int.Parse(Console.ReadLine());
            double prep = (double)timeForShooting * 0.15;
            double neededTime = (prep + scenesNum * sceneLength);
            if (timeForShooting >= neededTime)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(timeForShooting-neededTime)} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(neededTime-timeForShooting)} minutes.");
            }
        }
    }
}
