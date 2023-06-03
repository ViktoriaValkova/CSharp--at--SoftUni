using System;

namespace P03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumPrime = 0;
            int sumNotPrime = 0;
            string input = "";
            bool isPrime = false;
            int counterDivision = 0;
            while ((input = Console.ReadLine()) != "stop")
            {
                int num = int.Parse(input);
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                for (int i = 2; i <= num; i++)   // can also be done without a counter, by setting i<num; 
                {
                    if (num % i == 0) //not Prime
                    {
                       counterDivision++;
                    }
                    if (counterDivision > 1)
                    { 
                        isPrime = false;
                    }
                    else 
                    {
                        isPrime =true;
                    }
                }
                if (isPrime) { sumPrime+= num; }
                else { sumNotPrime+= num; }
                counterDivision = 0;
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNotPrime}");
        }
    }
}
