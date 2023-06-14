using System;

namespace P06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberK = int.Parse(Console.ReadLine());
            int numberL = int.Parse(Console.ReadLine());
            int numberM = int.Parse(Console.ReadLine());
            int numberN = int.Parse(Console.ReadLine());
            int changeCounter = 0;
            bool noMoreChanges = false;
            for (int i = numberK; i <= 8; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 9; j >= numberL; j--)
                    {
                        if (j % 2 != 0)
                        {
                            for (int k = numberM; k <= 8; k++)
                            {
                                if (k % 2 == 0)
                                {
                                    for (int l = 9; l >= numberN; l--)
                                    {
                                        if (l % 2 != 0)
                                        {
                                            //possible combinations 
                                            if (i == k && j == l) // invalid combinations
                                            {
                                                Console.WriteLine("Cannot change the same player.");
                                            }
                                            else
                                            {
                                                Console.WriteLine($"{i}{j} - {k}{l}");
                                                changeCounter++;
                                                if (changeCounter == 6)
                                                {
                                                    noMoreChanges = true;
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    if (noMoreChanges)
                                    {
                                        break;
                                    }
                                }
                            }
                            if (noMoreChanges)
                            {
                                break;
                            }
                        }
                    }
                }
                if (noMoreChanges)
                {
                    break;
                }
            }
        }
    }
}
