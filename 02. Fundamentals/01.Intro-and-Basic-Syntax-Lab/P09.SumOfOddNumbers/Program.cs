using System;

namespace P09.SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCnt = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= numberCnt*2; i+=2)
            {
                    Console.WriteLine(i);
                    sum += i;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
