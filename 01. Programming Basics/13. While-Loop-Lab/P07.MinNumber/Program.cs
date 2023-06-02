using System;

namespace P07.MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int minNumber = int.MaxValue;
            while (number != "Stop")
            {
                int numberAsInt = int.Parse(number);
                if (numberAsInt < minNumber) 
                {
                       minNumber= numberAsInt;
                }
                number = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
