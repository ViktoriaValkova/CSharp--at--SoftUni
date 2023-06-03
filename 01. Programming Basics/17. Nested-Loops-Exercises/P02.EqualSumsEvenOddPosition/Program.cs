using System;

namespace P02.EqualSumsEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            for (int i = number1; i <= number2; i++)
            {
                string asText = i.ToString();
                int evenSum = 0;
                int oddSum = 0;
                for (int position = 0; position < asText.Length; position++)
                {
                    int digit = int.Parse(asText[position].ToString());
                    if (position % 2 == 0) // even index
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }

                }
                if (oddSum == evenSum)
                {
                    Console.Write($"{asText} ");
                }
            }



        }
    }
}
