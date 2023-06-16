using System;

namespace P12.EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum % 2 != 0)
                {
                    Console.WriteLine("Please write an even number.");
                }
                else if (currentNum % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(currentNum)}");
                    break;
                }
            }
        }
    }
}
