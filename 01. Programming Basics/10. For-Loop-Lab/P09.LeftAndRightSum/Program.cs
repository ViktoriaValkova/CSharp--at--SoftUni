using System;

namespace LoopS
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftsum = 0;
            int rightsum = 0;
            for (int i = 1; i <= n; i++)
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    leftsum += firstNumber + secondNumber;
                }
                else
                {
                    rightsum += firstNumber + secondNumber;
                }

            }
            if (leftsum == rightsum)
            {
                Console.WriteLine($"Yes, sum = {leftsum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftsum - rightsum)}");
            }
        }
    }
}