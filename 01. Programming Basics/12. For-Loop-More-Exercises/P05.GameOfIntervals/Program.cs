using System;

namespace P05.GameOfIntervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numberOfMoves = int.Parse(Console.ReadLine());
            double points = 0;
            int zero = 0;
            int ten = 0;
            int twenty = 0;
            int thirty = 0;
            int forty = 0;
            for (int i = 0; i < numberOfMoves; i++) 
            { 
               int number = int.Parse(Console.ReadLine());
                if (number >= 0 && number <= 9)
                {
                    zero++;
                    points += number * 0.2;
                }
                else if (number>=10 && number<= 19)
                {
                    ten++;
                    points += number * 0.3;
                }
                else if (number >=20 && number <= 29)
                {
                    twenty++;
                    points += number * 0.4;
                }
                else if (number >= 30 && number <= 39)
                {
                    thirty++;
                    points += 50;
                }
                else if (number >= 40 && number <= 50 )
                {
                    forty++;
                    points += 100;
                }
                else
                {
                    points /= 2.0;
                }
                
            }
        Console.WriteLine($"{points:f2}");
            Console.WriteLine($"From 0 to 9: {zero*100.0/numberOfMoves:f2}%");
            Console.WriteLine($"From 10 to 19: {ten * 100.0 / numberOfMoves:f2}%");
            Console.WriteLine($"From 20 to 29: {twenty * 100.0 / numberOfMoves:f2}%");
            Console.WriteLine($"From 30 to 39: {thirty * 100.0 / numberOfMoves:f2}%");
            Console.WriteLine($"From 40 to 50: {forty * 100.0 / numberOfMoves:f2}%");
            Console.WriteLine($"Invalid numbers: {(numberOfMoves-zero -ten-twenty-thirty-forty) * 100.0 / numberOfMoves:f2}%");
        }
    }
}
