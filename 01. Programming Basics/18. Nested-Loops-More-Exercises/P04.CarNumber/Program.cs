﻿using System;

namespace P04.CarNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    for (int k = start; k <= end; k++)
                    {
                        if ((j + k) % 2 == 0)
                        {
                            for (int l = start; l <= end; l++)
                            {
                                if ((i % 2 == 0 && l % 2 != 0) || (i % 2 != 0 && l % 2 == 0))
                                {
                                   if (i > l)
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
    }
}
