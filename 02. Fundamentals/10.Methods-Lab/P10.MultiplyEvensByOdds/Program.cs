using System.Threading.Channels;

namespace P10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine(GetMultipleOfEvenAndOdds(number));

        }
        static int GetMultipleOfEvenAndOdds(int number)
        {
            return GetSumOfEven(number)*GetSumOfOdd(number);
        }
        static int GetSumOfEven(int number)
        {
                int sumEven = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    sumEven += digit;
                }
                number /= 10;
            }
            return sumEven;
        }
        static int GetSumOfOdd (int number)
        {
            int sumOdd = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    sumOdd += digit;
                }
                number /= 10;
            }
            return sumOdd;
        }
    }
}