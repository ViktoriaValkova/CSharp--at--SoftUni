using System;
using System.Threading.Channels;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string viewing = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            int seats = columns*rows;
            double price = 0.0; 
            switch (viewing) 
            {
                case "Premiere":
                    price = 12.00;
                    break;
                case "Normal":
                    price = 7.50;
                    break;
                case "Discount":
                    price = 5.00; 
                    break;
            }
            double result = (seats*price);
            Console.WriteLine($"{result:f2} leva.");
        }
    }
}