using System;

namespace P08.NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;
            for (int i = 1; i <= numberCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber < minNumber)
                {
                    minNumber = currentNumber;
                }
                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
         }
    }
}
