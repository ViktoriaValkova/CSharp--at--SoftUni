using System;

namespace P08.EqualPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberPairs = int.Parse(Console.ReadLine());
            int firstNumber = 0;
            int secondNumber = 0;
            int sum = 0;
            int sum1 = 0;
            int difference = 0;
            for (int i = 0; i < numberPairs; i++)
            {

                sum1 = sum;
                firstNumber = int.Parse(Console.ReadLine());
                secondNumber = int.Parse(Console.ReadLine());
                sum = firstNumber + secondNumber;
                if (numberPairs == 1)
                {
                    sum1 = sum;
                }
                else
                { 
                    difference = Math.Abs(sum - sum1);
                }
            }
            if (sum1 == sum) 
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={difference}");
            }
        }
    }
}
