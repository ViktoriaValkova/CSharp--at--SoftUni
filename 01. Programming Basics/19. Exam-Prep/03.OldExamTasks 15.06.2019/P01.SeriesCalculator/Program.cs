using System;

namespace P01.SeriesCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seriesName = Console.ReadLine();
            int seasonsCnt = int.Parse(Console.ReadLine());
            int episodesCnt = int.Parse(Console.ReadLine());
            int episodeLength = int.Parse(Console.ReadLine());

            int specialEpisodesLength = seasonsCnt * 10;
            double addsLength = episodeLength * 0.2;
            double totalTime = (episodeLength + addsLength) * episodesCnt * seasonsCnt + specialEpisodesLength;
            Console.WriteLine($"Total time needed to watch the {seriesName} series is {Math.Floor(totalTime)} minutes.");
        }
    }
}
