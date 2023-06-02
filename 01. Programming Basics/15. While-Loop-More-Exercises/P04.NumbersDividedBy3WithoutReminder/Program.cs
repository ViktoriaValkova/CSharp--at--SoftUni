using System;

namespace P04.NumbersDividedBy3WithoutReminder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 3; i <= 99; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
