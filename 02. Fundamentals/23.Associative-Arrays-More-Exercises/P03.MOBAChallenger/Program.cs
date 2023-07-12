namespace P03.MOBAChallenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> playersByPosition =
                new Dictionary<string, Dictionary<string, int>>();

            string input;

            var playersByPoints = new Dictionary<string, int>();
            while ((input = Console.ReadLine()) != "Season end")
            {
                string[] info = input.Split();
                if (info.Length > 3)
                {
                    AddToPlayerPool(input, playersByPosition);
                    playersByPoints = FindSumPoints(playersByPosition);
                }
                else
                {
                    Fight(input, playersByPosition, playersByPoints);
                }
            }
            PrintResult(playersByPoints, playersByPosition);
        }

        private static void Fight(string input, Dictionary<string, Dictionary<string, int>> playersByPosition, Dictionary<string, int> playersByPoints)
        {
            string[] fightInfo = input.Split(" vs ").ToArray();
            string playerOne = fightInfo[0];
            string playerTwo = fightInfo[1];

            if (playersByPosition.ContainsKey(playerOne) && playersByPosition.ContainsKey(playerTwo))
            {
                if (playersByPosition[playerOne].Keys.Intersect(playersByPosition[playerTwo].Keys).Any())
                {
                    if (playersByPoints[playerOne] > playersByPoints[playerTwo])
                    {
                        playersByPoints.Remove(playerTwo);
                        playersByPosition.Remove(playerTwo);
                    }
                    else if (playersByPoints[playerOne] < playersByPoints[playerTwo])
                    {
                        playersByPoints.Remove(playerOne);
                        playersByPosition.Remove(playerOne);
                    }
                }
            }
        }

        private static void AddToPlayerPool(string input, Dictionary<string, Dictionary<string, int>> playersByPosition)
        {
            string[] playerInfo = input.Split(" -> ").ToArray();
            string player = playerInfo[0];
            string position = playerInfo[1];
            int points = int.Parse(playerInfo[2]);

            if (!playersByPosition.ContainsKey(player))
            {
                playersByPosition[player] = new Dictionary<string, int>();
                playersByPosition[player][position] = points;
            }

            if (!playersByPosition[player].ContainsKey(position))
            {
                playersByPosition[player][position] = points;
            }

            if (playersByPosition[player][position] < points)
            {
                playersByPosition[player][position] = points;
            }
        }

        private static Dictionary<string, int> FindSumPoints(Dictionary<string, Dictionary<string, int>> playersByPosition)
        {
            Dictionary<string, int> playersByPoints = new Dictionary<string, int>();
            foreach (var kvp in playersByPosition)
            {
                playersByPoints[kvp.Key] = 0;

                playersByPoints[kvp.Key] += kvp.Value.Sum(x => x.Value);
            }

            return playersByPoints;
        }

        private static void PrintResult(Dictionary<string, int> playersByPoints, Dictionary<string, Dictionary<string, int>> playersByPosition)
        {
            foreach (var pair in playersByPoints
                         .OrderByDescending(x => x.Value)
                         .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} skill");

                foreach (var positionPair in playersByPosition.Where(x => x.Key == pair.Key))
                {
                    foreach (var innerPair in positionPair.Value
                                 .OrderByDescending(x => x.Value)
                                 .ThenBy(x => x.Key))
                    {
                        Console.WriteLine($"- {innerPair.Key} <::> {innerPair.Value}");
                    }
                }
            }
        }
    }
}