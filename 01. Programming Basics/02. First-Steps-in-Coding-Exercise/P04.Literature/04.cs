using System;
namespace _04._Literature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pageCount = int.Parse(Console.ReadLine());
            int pagePerHour = int.Parse(Console.ReadLine());
            int dayCount = int.Parse(Console.ReadLine());
            double Rezult = pageCount / dayCount / pagePerHour;
            Console.WriteLine(Rezult);
        }
    }
}