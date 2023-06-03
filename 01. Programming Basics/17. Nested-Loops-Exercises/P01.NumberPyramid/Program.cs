using System;

namespace P01.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNum = 1;
            bool isItBigger = false;
            for (int rows = 1; rows <= n; rows++)   // 
            {
                for (int numPerRow = 1; numPerRow <= rows; numPerRow++)
                {
                    Console.Write($"{currentNum} ");
                    currentNum++;

                    if (currentNum > n)
                    {
                        isItBigger = true;
                        break;
                    }

                }
                Console.WriteLine();
                if (isItBigger)
                {
                    break;
                }

            }
        }
    }
}
