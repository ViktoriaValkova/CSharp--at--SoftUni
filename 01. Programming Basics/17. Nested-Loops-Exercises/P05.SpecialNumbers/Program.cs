using System;

namespace P05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int newNumber = 0;
            int x = 0;
            int y = 0;
            int z = 0;
            int w = 0;
            for (int i = 1111; i <= 9999; i++)
            {
                newNumber = i;
                x = newNumber % 10;
                y = newNumber / 10 % 10;
                z = newNumber /100 % 10;
                w = newNumber / 1000 % 100;

                if (x != 0 && y != 0 && z != 0 && w != 0)
                {
                    if (n % x == 0 && n % y == 0 && n % z == 0 && n % w == 0)
                    {
                        Console.Write(newNumber + " ");
                    }
                }
            }
        }
    }
}
