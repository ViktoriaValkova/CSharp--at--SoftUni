using System;

namespace P04.SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int low = int.Parse(Console.ReadLine());
            int high = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combinationCounter = 0;
            bool magicNumFound = false;
            for (int i = low; i <= high; i++)
            {
                for (int j = low; j <= high; j++)
                {

                    combinationCounter++;
                    if (i + j == magicNum)  // or it can be done by declaring i and j before the loops
                                             // and with the flag, writing combinations after the loops 
                    {
                        Console.WriteLine($"Combination N:{combinationCounter} ({i} + {j} = {magicNum})");
                        magicNumFound = true;
                        break;
                    }
                }
                if (magicNumFound) break;
            }
            if (!magicNumFound)
            {
                Console.WriteLine($"{combinationCounter} combinations - neither equals {magicNum}");
            }
        }
    }
}
