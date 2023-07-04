using System;
using System.Net.Security;

namespace P03.HeartDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine()
                .Split("@")
                .Select(int.Parse)
                .ToArray();

            string input;
            int cupidsIndex = 0;
            while ((input = Console.ReadLine()) != "Love!")
            {
                string[] cmdArg = input.Split();

                int jumpLength = int.Parse(cmdArg[1]);

                cupidsIndex = ValidateCupidsIndex (neighborhood,jumpLength, cupidsIndex);
                
                neighborhood[cupidsIndex] -= 2;

                if (neighborhood[cupidsIndex] < 0)
                {
                    Console.WriteLine($"Place {cupidsIndex} already had Valentine's day.");
                }
                if (neighborhood[cupidsIndex] ==0)
                {
                    Console.WriteLine($"Place {cupidsIndex} has Valentine's day.");
                    neighborhood[cupidsIndex] = -1;
                }
            }
            Console.WriteLine($"Cupid's last position was {cupidsIndex}.");
            int failedHouses = CheckHousesValue(neighborhood );

            if (failedHouses ==0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {failedHouses} places.");
            }
        }

         static int CheckHousesValue(int[] neighborhood)
        {
            int unsuccessfulCnt = 0;
            foreach (int house in neighborhood)
            {
                if (house > 1)
                {
                    unsuccessfulCnt++;
                }
            }
            return unsuccessfulCnt;
        }


        static int ValidateCupidsIndex(int[] neighborhood, int jumpLength, int index)
        {
            if (index + jumpLength >= neighborhood.Length)
            {
                index = 0; 
            }
            else
            {
                index += jumpLength;
            }
            return index;
        }
    }
}