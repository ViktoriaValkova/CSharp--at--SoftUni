using System;

namespace P07.Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int count = 1; count <= n; count++)
            {
                int current = int.Parse(Console.ReadLine());
                sum += current;
            }
            Console.WriteLine(sum);
        }
    }
}
