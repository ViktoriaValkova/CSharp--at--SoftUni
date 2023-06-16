using System;

namespace P11.MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            int multipler = int.Parse(Console.ReadLine());
            if (multipler > 10)
            {
                Console.WriteLine($"{integer} X {multipler} = {integer * multipler}");
            }
            else
            {
                for (int i = multipler; i <= 10; i++)
                {
                    Console.WriteLine($"{integer} X {i} = {integer * i}");
                }
            }
        }
    }
}
