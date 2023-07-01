namespace P10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endValue = int.Parse(Console.ReadLine());
            for (int i = 1; i <= endValue; i++)
            {
                if (DivisibleByEight(i) && HasOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }

            
                


        }
        static bool DivisibleByEight(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }
            if (sum % 8 == 0)
            {
                return true;
            }
            return false;
        }
        static bool HasOddDigit(int number)
        {

            int counter = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    counter++;
                }
                number /= 10;
            }
            if (counter >= 1)
            {
                return true;
            }
            return false;
        }
    }
}

