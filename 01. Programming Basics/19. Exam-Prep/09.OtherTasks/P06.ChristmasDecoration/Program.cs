using System;

namespace P06.ChristmasDecoration
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int budget = int.Parse(Console.ReadLine());
            string deco = string.Empty;
      
            while ((deco = Console.ReadLine()) != "Stop")
            {   
                       int sum = 0;   
                for (int i = 0; i <deco.Length; i++)
                {
                    sum += deco[i];
                }
                if (sum <= budget)
                {
                    budget -= sum;
                    Console.WriteLine("Item successfully purchased!");
                }
                else
                {
                    Console.WriteLine("Not enough money!");
                    break; 
                }
            }
            if (deco == "Stop")
            {
                Console.WriteLine($"Money left: {budget}");
            }
        }
    }
}
