using System;

namespace P02.Skeleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int minutesGoal = int.Parse(Console.ReadLine());
            int secondsGoal = int.Parse(Console.ReadLine());
            int goalSum = minutesGoal * 60 + secondsGoal;
            double tubeLength = double.Parse(Console.ReadLine());
            double secondsForHundredMeters = double.Parse(Console.ReadLine());
            double slowingDown = tubeLength / 120* 2.5; // in seconds 
            double hisTry = tubeLength/100*secondsForHundredMeters - slowingDown;

            if (hisTry <= goalSum)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {hisTry:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {hisTry-goalSum:f3} second slower.");
            }
        }
    }
}
