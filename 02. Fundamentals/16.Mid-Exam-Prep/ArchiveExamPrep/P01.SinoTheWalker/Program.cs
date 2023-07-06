using System.Numerics;

namespace P01.SinoTheWalker.ThirdVersion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] timeInput = Console.ReadLine().Split(':');
            int hours = int.Parse(timeInput[0]) * 3600;
            int minutes = int.Parse(timeInput[1]) * 60;
            int seconds = int.Parse(timeInput[2]);
            int totalInputInSeconds = hours + minutes + seconds;

            BigInteger steps = int.Parse(Console.ReadLine());
            BigInteger secPerStep = int.Parse(Console.ReadLine());

            BigInteger totalTimeInSeconds = (steps * secPerStep) + totalInputInSeconds;

            BigInteger arriveHour = (totalTimeInSeconds / 3600) ;
            BigInteger arriveMinute = (totalTimeInSeconds / 60);
            arriveMinute = arriveMinute % 60;
            // or arriveMinutes  = totalTImeInSeconds - arriveHours*3600 => gives the minutes left in seconds 
             //     arriveMinutes = minutes /60 ; 

            BigInteger arriveSecond = totalTimeInSeconds % 60;
            arriveHour %= 24; 

            Console.WriteLine($"Time Arrival: {arriveHour:00}:{arriveMinute:00}:{arriveSecond:00}");
        }
    }
}