﻿using System;
using System.Globalization;

namespace P06.Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            for (int floorNumber = floors; floorNumber >= 1; floorNumber--)
            {
                
                for (int roomNumber = 0; roomNumber < rooms; roomNumber++)
                {
                    if (floorNumber == floors)
                    {
                    Console.Write($"L{floorNumber}{roomNumber} ");
                    }
                    else if (floorNumber % 2 == 0)
                    {
                     Console.Write($"O{floorNumber}{roomNumber} ");
                    }
                    else
                    {
                        Console.Write($"A{floorNumber}{roomNumber} ");
                    }
                   
                }
                Console.WriteLine();
            }
        }
    }
}
