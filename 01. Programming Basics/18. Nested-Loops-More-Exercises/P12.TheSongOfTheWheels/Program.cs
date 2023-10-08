using System;

namespace P12.TheSongOfTheWheels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int control = int.Parse(Console.ReadLine());
            int counter = 0;
            string pass = "";
            bool passFound = false;
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= c; d++)
                        {
                            if (a < b && c > d)
                            {
                                if ((a * b + c * d) == control)
                                {
                                    Console.Write($"{a}{b}{c}{d} ");
                                    counter++;
                                    if (counter == 4)
                                    {
                                        pass = ($"{a}{b}{c}{d}");
                                        passFound = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            if (passFound)
            {
                  
                Console.WriteLine($"Password: {pass}");
            }
            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}
