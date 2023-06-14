using System;

namespace P04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCnt = int.Parse(Console.ReadLine());
            double aboveFive = 0;
            double aboveFour = 0;
            double aboveThree = 0;
            double aboveTwo = 0;
            double sumGrade = 0;
            for (int i = 1; i <= studentsCnt; i++)
            {
                double currentGrade = double.Parse(Console.ReadLine());
                sumGrade += currentGrade;
                if (currentGrade >= 5.0)
                {
                    aboveFive++;
                }
                else if (currentGrade >= 4.0)
                {
                    aboveFour++;
                }
                else if (currentGrade >= 3.0)
                {
                    aboveThree++;
                }
                else
                {
                    aboveTwo++;
                }
            }
            Console.WriteLine($"Top students: {aboveFive / studentsCnt * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {aboveFour / studentsCnt * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {aboveThree / studentsCnt * 100:f2}%");
            Console.WriteLine($"Fail: {aboveTwo / studentsCnt * 100:f2}%");
            Console.WriteLine($"Average: {sumGrade / studentsCnt:f2}");
        }
    }
}
