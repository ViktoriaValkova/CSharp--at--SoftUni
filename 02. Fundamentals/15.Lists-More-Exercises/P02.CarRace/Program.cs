using System.ComponentModel.Design;
using System.Reflection;

namespace P02.CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            double timeLeftRacer = Math.Round(CalculateTime (numbers),1);
            numbers.Reverse();
            double timeRightRacer = Math.Round(CalculateTime (numbers),1);

            if (timeLeftRacer < timeRightRacer)
            {
                Console.WriteLine($"The winner is left with total time: {timeLeftRacer}");
            }
            else 
            {
                Console.WriteLine($"The winner is right with total time: {timeRightRacer}");
            }
        }

        static double CalculateTime(List<double> numbers)
        {
            double time = 0;
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                time += numbers[i];
                time = CheckForZero(numbers[i], time);
            }
            return time;
        }

        static double CheckForZero(double number, double time)
        {
            if (number == 0)
            {
                time *= 0.8;
            }

            return time;
        }
    }
}