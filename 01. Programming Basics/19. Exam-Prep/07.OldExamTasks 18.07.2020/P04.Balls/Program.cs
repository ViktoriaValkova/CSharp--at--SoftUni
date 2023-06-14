using System;

namespace P04.Balls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ballsCnt = int.Parse(Console.ReadLine());
            double points = 0;
            int redCnt = 0;
            int orangeCnt = 0;
            int yellowCnt = 0;
            int whiteCnt = 0;
            int blackCnt = 0;
            int othersCnt = 0;
            for (int i = 0; i < ballsCnt; i++)
            {
                string color = Console.ReadLine();
                switch (color)
                {
                    case "red": points += 5; redCnt++; break;
                    case "orange": points += 10; orangeCnt++; break;
                    case "yellow": points += 15; yellowCnt++; break;
                    case "white": points += 20; whiteCnt++; break;
                    case "black": points = Math.Floor(points / 2.0); blackCnt++; break;
                    default: othersCnt++; break;
                }
            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {redCnt}");
            Console.WriteLine($"Orange balls: {orangeCnt}");
            Console.WriteLine($"Yellow balls: {yellowCnt}");
            Console.WriteLine($"White balls: {whiteCnt}");
            Console.WriteLine($"Other colors picked: {othersCnt}");
            Console.WriteLine($"Divides from black balls: {blackCnt}");
        }
    }
}
