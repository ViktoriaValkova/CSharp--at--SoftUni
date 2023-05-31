using System;
namespace _03._Odd_or_Even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else Console.WriteLine("odd");
        }
    }
}