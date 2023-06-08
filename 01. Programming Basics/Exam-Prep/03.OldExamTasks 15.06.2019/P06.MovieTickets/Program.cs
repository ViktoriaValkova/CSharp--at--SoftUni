using System;

namespace P06.MovieTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int i = a1; i <= a2 - 1; i++)
            {
               char c = (char)i;
                if (i % 2 != 0)
                {
                    for (int j = 1; j <= n - 1; j++)
                    {
                        for (int k = 1; k <= n / 2 - 1; k++)
                        {
                            int symbolFour = i; 
                            if ((j + k + symbolFour) % 2 != 0)
                            {
                                Console.WriteLine($"{c}-{j}{k}{symbolFour}");
                            }
                        }

                    }
                }

            }
        }
    }
}
