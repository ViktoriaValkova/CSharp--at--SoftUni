using System;

namespace P02.MountainRun   // 28/29.03.2020
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double record = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double slowing = Math.Floor(distanceInMeters / 50.0) * 30;
            double hisTry = distanceInMeters * timeForOneMeter + slowing;
            if (hisTry < record)
            {
                Console.WriteLine($"Yes! The new record is {hisTry:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {hisTry-record:f2} seconds slower.");
            }
        }
    }
}
