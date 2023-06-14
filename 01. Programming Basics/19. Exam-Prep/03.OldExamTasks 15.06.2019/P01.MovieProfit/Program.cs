using System;

namespace P01.MovieProfit     // 15/16.06.2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int daysCnt =int.Parse(Console.ReadLine()); 
            int ticketCnt =int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            int percentageForMovieTheater = int.Parse(Console.ReadLine());

            double income = daysCnt*ticketCnt*ticketPrice;
            double finalIncome = income - (income * percentageForMovieTheater / 100.0);
            Console.WriteLine($"The profit from the movie {movieName} is {finalIncome:f2} lv.");
        }
    }
}
