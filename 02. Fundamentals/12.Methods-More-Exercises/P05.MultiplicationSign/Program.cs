namespace P05.MultiplicationSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WhatIsTHeProduct(3));
        }
        static string WhatIsTHeProduct(int count)
        {
            bool isNegative = false;
            bool isZero = false;
            int negativeCnt = 0;
            for (int i = 0; i < count; i++)
            {
                double currNum = double.Parse(Console.ReadLine());
                if (NumberIsPositive(currNum))
                {
                    continue;
                }
                if (!isZero)
                {                  
                isZero = NumberIsZero(currNum);
                }
                if (NumberIsNegative(currNum))
                {
                    negativeCnt++;
                }
            }
            if (isZero)
            {
                return "zero";
            }
            if (negativeCnt ==1 || negativeCnt == 3)
            {
                return "negative";
            }
            else
            {
                return "positive";
            }
        }
        static bool NumberIsPositive (double  num)
        {
            return num > 0;
        }
        static bool NumberIsNegative(double num)
        {
            return num < 0;
        }
        static bool NumberIsZero(double num)
        {
            return num == 0;
        }
    }
}