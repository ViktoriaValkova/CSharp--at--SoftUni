using System;

namespace P09.SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combCounter = 0;
            bool isFound = false;
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    combCounter++;
                    if (i + j == magicNum)
                    {
                        isFound = true;
                        Console.WriteLine($"Combination N:{combCounter} ({i} + {j} = {magicNum})");
                        break;
                    }
                }
                if (isFound) 
                { 
                    break; 
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"{combCounter} combinations - neither equals {magicNum}");
            }
        }
    }
}
