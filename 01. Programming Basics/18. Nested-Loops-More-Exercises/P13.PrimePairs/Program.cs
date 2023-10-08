using System;

namespace P13.PrimePairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startFirstPair = int.Parse(Console.ReadLine());
            int startSecondPair = int.Parse(Console.ReadLine());
            int endRangeFirstPair = int.Parse(Console.ReadLine()) + startFirstPair;
            int endRangeSecondPair = int.Parse(Console.ReadLine()) + startSecondPair;
            bool isPairPrime = true;
            for (int firstPair = startFirstPair; firstPair <= endRangeFirstPair; firstPair++)
            {  
                for (int i = 2; i < firstPair; i++)
                {
                    if (firstPair % i == 0) //not Prime
                    {
                        isPairPrime = false;
                        break;
                    }
                    else isPairPrime = true;

                }
                if (isPairPrime)
                {
                    for (int secondPair = startSecondPair; secondPair <= endRangeSecondPair; secondPair++)
                    {
                        for (int i = 2; i < secondPair; i++)
                        {
                            if (secondPair % i == 0) //not Prime
                            {
                                isPairPrime = false;
                                break;
                            }
                            else { isPairPrime = true;}
                        }
                        if (isPairPrime)
                        {
                            Console.WriteLine($"{firstPair}{secondPair} ");
                        }                       
                    }
                }
            }
        }
    }
}


