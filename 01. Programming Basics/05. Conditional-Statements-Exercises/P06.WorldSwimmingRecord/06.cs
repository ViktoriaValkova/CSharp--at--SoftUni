using System;
namespace _06._World_swimming_record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double timeNeeded = distance * timeForOneMeter;
            double addedSeconds = Math.Floor(distance / 15.0);
            addedSeconds *=12.5;
            double timeAll = timeNeeded + addedSeconds;
            //timeNeeded += addedSeconds// 
            if (timeAll >= recordInSeconds)
            {
                Console.WriteLine($"No, he failed! He was {timeAll - recordInSeconds:f2} seconds slower.");
            }
            else { Console.WriteLine($" Yes, he succeeded! The new world record is {timeAll:f2} seconds."); }
        }
    }
}