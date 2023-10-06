using System;

namespace P02.LettersCombinations
{
    internal class Program
    {
        private static char alphabet;

        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char missedLetter = char.Parse(Console.ReadLine());
            int counter = 0;

           for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        if (i == missedLetter || j == missedLetter || k == missedLetter)
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write($"{i}{j}{k} ");
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
