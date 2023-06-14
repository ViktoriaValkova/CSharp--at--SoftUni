using System;

namespace P06.NameGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            int maxPoints = 0;
            string winner = string.Empty;
            while ((name = Console.ReadLine()) != "Stop") 
            {
                int currentLetter = 0;
                int points = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    currentLetter = name[i];
                    int currentNumber = int.Parse(Console.ReadLine());
                    if (currentLetter == currentNumber)
                    {
                        points += 10;
                    }
                    else
                    {
                        points += 2;
                    }
                }
                if (points >= maxPoints)
                {
                    maxPoints = points;
                    winner = name;
                }
            }
            Console.WriteLine($"The winner is {winner} with {maxPoints} points!");
        }
    }
}
