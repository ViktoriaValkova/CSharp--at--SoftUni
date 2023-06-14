using System;

namespace P06.FavoriteMovie      // 15/16.06.2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int movieCounter = 0;
            string movieTitle = String.Empty;

            int maxPoints = 0;
            string bestMovie = String.Empty;

            while ((movieTitle = Console.ReadLine()) != "STOP")
            {
                           int points = 0;
                
                movieCounter++;
                for (int i = 0; i < movieTitle.Length; i++) 
                {
                    char c = movieTitle[i];   // no need for casting (char)
                    points += c;
                    if (c >= 65 && c <= 90)   // can be done with char.Upper(c)
                    {
                        points -= movieTitle.Length;
                    }
                    if (c >= 97 && c <= 122)
                    {
                        points -= 2*movieTitle.Length; // can be done with char.IsLower(c)
                    }
                }
                if (points > maxPoints)
                {
                    maxPoints = points;
                    bestMovie = movieTitle;
                }
               if (movieCounter == 7)
                {
                    Console.WriteLine("The limit is reached.");
                    break;
                }
            }
            Console.WriteLine($"The best movie for you is {bestMovie} with {maxPoints} ASCII sum.");
        }
    }
}
