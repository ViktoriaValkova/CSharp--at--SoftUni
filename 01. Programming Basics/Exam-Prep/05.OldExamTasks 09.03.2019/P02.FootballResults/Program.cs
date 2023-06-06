using System;

namespace P02.FootballResults
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int winsCount = 0;
            int losesCount = 0;
            int drawsCount = 0;
            for (int i = 1; i <= 3; i++)
            {
                string result = Console.ReadLine();
                int resultOurs = 0;
                int resultTheirs = 0;
                for (int j = 0; j <= result.Length - 1; j++) // can be done without the second for loop, just by reading the 0. and 2. index
                {                                            // and adding them to Ours and Theirs result. 

                    if (j == 0)
                    {
                        resultOurs = result[j];
                    }
                    else if (j == 2)
                    {
                        resultTheirs = result[j];
                    }

                }
                if (resultOurs > resultTheirs)
                {
                    winsCount++;
                }
                else if (resultOurs < resultTheirs)
                {
                    losesCount++;
                }
                else if (resultOurs == resultTheirs)
                {
                    drawsCount++;
                }
            }
            Console.WriteLine($"Team won {winsCount} games.");
            Console.WriteLine($"Team lost {losesCount} games.");
            Console.WriteLine($"Drawn games: {drawsCount}");
        }
    }
}
