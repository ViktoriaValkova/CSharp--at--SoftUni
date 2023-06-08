using System;

namespace P06.BarcodeGenerator              // 18/19.07.2020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lower = (Console.ReadLine());
            string higher = (Console.ReadLine());

            for (int i = lower[0]- 48; i <= higher[0] - 48; i++)
            {
                for (int j = lower[1] - 48; j <= higher[1] - 48; j++)
                {
                    for (int k = lower[2] - 48; k <= higher[2] - 48; k++)
                    {
                        for (int l = lower[3] - 48; l <= higher[3] - 48; l++)
                        {
                            if (i % 2 != 0 && j % 2 != 0 && k % 2 != 0 && l % 2 != 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
