using System;
namespace P02.SleepyTomCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());
            int daysWorking = 365 - daysOff;
            int minutesToPlay = 63 * daysWorking + 127 * daysOff;
            if (minutesToPlay <= 30000)
            {
                int timeLeft = 30000 - minutesToPlay;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{timeLeft / 60} hours and {timeLeft % 60} minutes less for play");
            }
            else
            {
                int timeLeft = minutesToPlay - 30000;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{timeLeft / 60} hours and {timeLeft % 60} minutes more for play");
            }

        }

    }
}