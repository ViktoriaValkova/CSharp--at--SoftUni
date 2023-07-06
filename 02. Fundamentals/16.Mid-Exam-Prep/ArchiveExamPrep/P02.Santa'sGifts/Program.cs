using System;
using System.Collections.Generic;
using System.Threading.Channels;
using System.Linq;


namespace P02.Santa_sGifts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCmds = int.Parse(Console.ReadLine());
            List<int> houses = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

                int currentPosition = 0;
            for (int i = 0; i < numberCmds; i++)
            {
                string[] cmdArg = Console.ReadLine().Split();
                string command = cmdArg[0];
                if (command == "Forward")
                {
                    int steps = int.Parse(cmdArg[1]);
                   MoveForward(houses, ref currentPosition, steps);
                }
                else if (command == "Back")
                {
                    int steps = int.Parse(cmdArg[1]);
                    MoveBack(houses, ref currentPosition, steps);
                }
                else if (command == "Gift")
                {
                    int index = int.Parse(cmdArg[1]);
                    int houseNumber = int.Parse(cmdArg[2]);
                    currentPosition= InsertNewHouse(houses, index, houseNumber,currentPosition);
                }
                else // swap 
                {
                    int firstHouse = int.Parse(cmdArg[1]);
                    int secondHouse = int.Parse(cmdArg[2]);
                    SwapHouses (houses, firstHouse, secondHouse);
                }

            }
            Console.WriteLine($"Position: {currentPosition}");
            Console.WriteLine(string.Join(", ",houses));
        }
        static void MoveForward(List<int> houses, ref int currentPosition, int steps)
        {
            if (CheckIndexForward(houses,  currentPosition,steps))
            {
                currentPosition += steps;
            houses.RemoveAt(currentPosition);
            }

        }
        static bool CheckIndexForward(List<int> houses,  int currentPosition, int steps)
         {
             if (currentPosition + steps < 0 || currentPosition + steps >= houses.Count|| steps <0)
             {
                 return false;
             }

             return true;
         } 
        static void MoveBack(List<int> houses, ref int currentPosition, int steps)
        {
           if (CheckIndexBack(houses,  currentPosition, steps))
           {
               currentPosition -= steps;
           houses.RemoveAt(currentPosition);
           }
        }
        static bool CheckIndexBack(List<int> houses,  int currentPosition, int steps)
         {
             if (currentPosition - steps < 0 || currentPosition - steps >= houses.Count || steps<0)
             {
                 return false;
             }

             return true;
         }
        static int InsertNewHouse(List<int> houses, int index, int houseNumber,int position)
        {
            if (CheckIndex(houses, index)) 
            {
                houses.Insert(index,houseNumber);
            return index;

            }

            return position;
        }
        static bool CheckIndex(List<int> houses, int index)
        {
            if (index < 0 || index >= houses.Count)
            {
                return false;
            }

            return true;
        }
        static void SwapHouses(List<int> houses, int firstHouse, int secondHouse)
        {
            int firstIndex = houses.IndexOf(firstHouse);
            int secondIndex = houses.IndexOf(secondHouse);

            if (CheckIndex(houses, firstIndex) && CheckIndex(houses, secondIndex))
            {
                houses[firstIndex] = secondHouse;
                houses[secondIndex] = firstHouse;
            }
        }
    }
}