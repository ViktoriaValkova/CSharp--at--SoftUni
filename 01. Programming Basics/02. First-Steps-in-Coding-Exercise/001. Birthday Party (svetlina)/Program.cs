using System;
namespace _001._Birthday_Party__svetlina_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse (Console.ReadLine());
            double animator = rent / 3;
            double cake = rent * 0.2;
            double drinks = cake * 0.55;
            double moneyNeeeded = rent + animator + cake+ drinks;
            Console.WriteLine(moneyNeeeded); 
        }
    }
}