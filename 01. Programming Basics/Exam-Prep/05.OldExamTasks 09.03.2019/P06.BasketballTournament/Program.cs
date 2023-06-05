using System; 

namespace P06.BasketballTournament   // Exam 15/16.06.19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tournamentName = "";
            int pointsOurTeam = 0;
            int pointsTheirTeam = 0;
            int winsCount = 0;
            int losesCount = 0;
            int countAllGames = 0;
            while ((tournamentName = Console.ReadLine()) != "End of tournaments") 
            { 
                int numberGames = int.Parse(Console.ReadLine());
                countAllGames += numberGames;  // again can be omitted here and done as sum of won and lost sfter the while cycle
                for (int i = 1; i <= numberGames; i++)
                {
                     pointsOurTeam = int.Parse(Console.ReadLine());
                     pointsTheirTeam = int.Parse(Console.ReadLine());
                    if (pointsOurTeam > pointsTheirTeam)
                    {
                      winsCount++;
                        Console.WriteLine($"Game {i} of tournament {tournamentName}: win with {pointsOurTeam-pointsTheirTeam} points.");
                    }
                    else
                    {
                        losesCount++;
                        Console.WriteLine($"Game {i} of tournament {tournamentName}: lost with {pointsTheirTeam-pointsOurTeam} points.");
                    }
                }           
            }
            Console.WriteLine($"{winsCount*100.0/countAllGames:f2}% matches win");
            Console.WriteLine($"{losesCount * 100.0 / countAllGames:f2}% matches lost");
        }
    }
}
