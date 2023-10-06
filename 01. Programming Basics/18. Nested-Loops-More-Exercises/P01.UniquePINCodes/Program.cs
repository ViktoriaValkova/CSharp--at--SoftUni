using System;

namespace P01.UniquePINCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int upperFirst = int.Parse(Console.ReadLine());
            int upperSecond = int.Parse(Console.ReadLine());
            int upperThird = int.Parse(Console.ReadLine());

            int digit1 = 0; int digit2 = 0; int digit3 = 0;

            for (int i = 1; i <= upperFirst; i++)
            {
                digit1 = i;
                if (digit1 % 2 == 0)
                {
                    for (int j = 2; j <= upperSecond; j++)
                    {
                        digit2 = j;
                        if (digit2 == 2 || digit2 == 3 || digit2 == 5 || digit2 == 7) // this way we skip the check for prime number
                        {
                            for (int k = 1; k <= upperThird; k++)
                            {
                                digit3 = k;
                                if (digit3 % 2 == 0)
                                {
                                    { Console.WriteLine($"{digit1} {digit2} {digit3}"); }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
