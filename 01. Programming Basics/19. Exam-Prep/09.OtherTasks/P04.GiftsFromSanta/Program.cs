using System;

namespace P04.GiftsFromSanta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numN = int.Parse(Console.ReadLine());
            int numM = int.Parse(Console.ReadLine());
            int numS = int.Parse(Console.ReadLine());
            for (int i = numM; i >= numN; i--)
            {
                if (i % 2 == 0 && i % 3 == 0 )
                {
                    
                    if (i == numS)
                    {
                        break;
                    }
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
