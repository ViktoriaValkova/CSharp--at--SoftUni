using System;

namespace P04.GameNumberWars    // 09/10.03.2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerOne = Console.ReadLine();
            string playerTwo = Console.ReadLine();
            string input = string.Empty;
            int playerOnePoints = 0;
            int playerTwoPoints = 0;
            bool numberWars = false;
            string winner = string.Empty;
            int winnerPoints = 0;

            while ((input = Console.ReadLine()) != "End of game")
            {
                int playerOneCard = int.Parse(input);
                int playerTwoCard = int.Parse(Console.ReadLine());
                if (numberWars)
                {
                    if (playerOneCard > playerTwoCard)
                    {
                        winner = playerOne;
                        winnerPoints = playerOnePoints;

                    }
                    else if (playerTwoCard > playerOneCard)
                    {
                        winner = playerTwo;
                        winnerPoints = playerTwoPoints;
                    }
                    break;
                }

                if (playerOneCard > playerTwoCard)
                {
                    playerOnePoints += playerOneCard - playerTwoCard;
                }
                else if (playerTwoCard > playerOneCard)
                {
                    playerTwoPoints += playerTwoCard - playerOneCard;
                }
                else //if cards ar even 
                {
                    numberWars = true;
                    Console.WriteLine("Number wars!");
                    continue;
                }
            }
            if (input == "End of game")
            {
                Console.WriteLine($"{playerOne} has {playerOnePoints} points");
                Console.WriteLine($"{playerTwo} has {playerTwoPoints} points");
            }
            else
            {
                Console.WriteLine($"{winner} is winner with {winnerPoints} points");
            }
        }
    }
}
