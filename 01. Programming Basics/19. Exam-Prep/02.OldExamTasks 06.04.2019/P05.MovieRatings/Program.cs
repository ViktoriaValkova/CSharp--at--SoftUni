using System;

namespace P05.MovieRatings    // 06/07.04.2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberMovies = int.Parse(Console.ReadLine());
            double sumRating = 0;
            double highestRating = double.MinValue; // or 0
            double lowestRating = double.MaxValue;  // or 0
            string lowestMovie = string.Empty;
            string highestMovie = string.Empty;

            for (int i = 0; i < numberMovies; i++)
            {
                string movieName = Console.ReadLine();
                double movieRating = double.Parse(Console.ReadLine());
                sumRating += movieRating;
                if (movieRating > highestRating)
                {
                    highestRating = movieRating;
                    highestMovie = movieName;
                }
                if (movieRating < lowestRating)
                {
                    lowestRating = movieRating;
                    lowestMovie = movieName;
                }
            }
            double averageRating = sumRating / numberMovies;
            Console.WriteLine($"{highestMovie} is with highest rating: {highestRating:f1}");
            Console.WriteLine($"{lowestMovie} is with lowest rating: {lowestRating:f1}");
            Console.WriteLine($"Average rating: {averageRating:f1}");
        }
    }
}
