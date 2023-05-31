using System;
namespace _08._Lunch_break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seriesName = Console.ReadLine();
            int episodeLength = int.Parse(Console.ReadLine());
            int brakeLength = int.Parse(Console.ReadLine());
            double lunchTime = brakeLength / 8.0;
            double pauseTime = brakeLength / 4.0;
            double timeLeftOfBrake = brakeLength - lunchTime - pauseTime;
            if (timeLeftOfBrake >= episodeLength)
            {
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(timeLeftOfBrake - episodeLength)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(episodeLength - timeLeftOfBrake)} more minutes.");
            }
        }
    }
}