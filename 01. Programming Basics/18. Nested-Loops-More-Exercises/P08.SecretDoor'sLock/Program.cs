using System;

namespace P01.ALternative._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstUpper = int.Parse(Console.ReadLine());
            int secondUpper = int.Parse(Console.ReadLine());
            int thirdUpper = int.Parse(Console.ReadLine());

            for (int i = 1; i <= firstUpper; i++)
            {
                for (int j = 1; j <= secondUpper; j++)
                {
                    for (int k = 1; k <= thirdUpper; k++)
                    {
                        if (i % 2 == 0 && k % 2 == 0)
                        {
                            if (j == 2 || j == 3 || j == 5 || j == 7)
                            {
                                Console.WriteLine($"{i} {j} {k}");
                            }

                        }
                    }

                }

            }
        }
    }
}
