using System;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;

namespace P04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double sum = 0;
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int moneyToReceive = 9; //because her brother takes 1 
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0) //even birthdays, recieves money
                {
                    sum += moneyToReceive;
                    moneyToReceive += 10;
                     
                    // sum += i * 5 - 1; // for every even birthday she receives age*5 lv - 1 her brother takes
                }
                else
                {
                    sum+= toyPrice;
                }
            }
            if (sum >= washingMachinePrice) 
            {
                Console.WriteLine($"Yes! {sum-washingMachinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachinePrice-sum:f2}");
            }
        }
    }
}
