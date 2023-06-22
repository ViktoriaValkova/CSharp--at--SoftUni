using System.Numerics;

namespace P11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowBallsCnt = int.Parse(Console.ReadLine());
            BigInteger highestValue = 0;
            int bestSnow = 0;
            int bestTime = 0;
            int bestQuality = 0;
            for (int i = 0; i < snowBallsCnt; i++)
            {
                 int snowBallSnow = int.Parse((Console.ReadLine()));
                 int snowBallTime = int.Parse((Console.ReadLine()));
                 int snowBallQuality = int.Parse((Console.ReadLine()));
                BigInteger snowBallValue = BigInteger.Pow(snowBallSnow / snowBallTime, snowBallQuality);
                if (snowBallValue > highestValue)
                {
                    highestValue = snowBallValue;
                    bestQuality = snowBallQuality;
                    bestSnow = snowBallSnow;
                    bestTime = snowBallTime;
                }
            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {highestValue} ({bestQuality})");
        }
    }
}