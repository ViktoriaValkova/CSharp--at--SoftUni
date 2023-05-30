using System;
namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int srok = int.Parse(Console.ReadLine());
            double lihva = double.Parse(Console.ReadLine());
            double rezult = deposit + srok * ((deposit * (lihva / 100.0)) / 12);
            Console.WriteLine(rezult);
        }
    }
}