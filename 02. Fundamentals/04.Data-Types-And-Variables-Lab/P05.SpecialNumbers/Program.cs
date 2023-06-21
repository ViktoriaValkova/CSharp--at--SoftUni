using System.Net.Http.Headers;
using System.Security;

namespace P05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                int currentNum = i;
                int sumDigits =0;
                while (currentNum > 0)
                {
                    sumDigits += currentNum % 10;
                    currentNum /= 10;
                }
                bool isSpecial = false;
                if (sumDigits == 5 || sumDigits ==7 || sumDigits == 11) 
                {
                    isSpecial = true;
                }
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}