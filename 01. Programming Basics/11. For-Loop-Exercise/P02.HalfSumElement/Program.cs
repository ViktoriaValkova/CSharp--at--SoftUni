using System;

namespace P02.HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNumber = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int newNumber = int.Parse(Console.ReadLine());
                sum += newNumber;
                if (newNumber > maxNumber)
                { maxNumber = newNumber; }
            }
            if (maxNumber == (sum - maxNumber))
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNumber}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(2 * maxNumber - sum)}");
            }
        }
    }
}
