using System;

namespace P10.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            for (int i =1; i <=10; i++)
            {
                Console.WriteLine($"{integer} X {i} = {integer*i}");
            }
        }
    }
}
