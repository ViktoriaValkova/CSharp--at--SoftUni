using System;

namespace P05.FootballTournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string footballTeam = Console.ReadLine();
            int playedGames = int.Parse(Console.ReadLine());
            int winCnt = 0;
            int drawCnt = 0;
            int lossCnt = 0;
            int pointsCnt = 0;
            if (playedGames == 0)
            {
                Console.WriteLine($"{footballTeam} hasn't played any games during this season.");
            }
            else
            {
                for (int i = 0; i < playedGames; i++)
                {
                    char result = char.Parse(Console.ReadLine());
                    switch (result)
                    {
                        case 'W': winCnt++; pointsCnt += 3; break;
                        case 'D':drawCnt++;pointsCnt++; break;
                        case 'L':lossCnt++; break;
                    }
                }
                Console.WriteLine($"{footballTeam} has won {pointsCnt} points during this season.");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W: {winCnt}");
                Console.WriteLine($"## D: {drawCnt}");
                Console.WriteLine($"## L: {lossCnt}");
                Console.WriteLine($"Win rate: {(double)winCnt/playedGames*100:f2}%");
            }

        }
    }
}
