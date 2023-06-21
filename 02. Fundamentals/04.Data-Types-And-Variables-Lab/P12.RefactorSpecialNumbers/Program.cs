namespace P12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            bool isSpecialNum = false;
            for (int i = 1; i <= number; i++)
            {
                int digit = i;
                int sum = 0;
                while (digit > 0)
                {
                    sum += digit % 10;
                    digit = digit / 10;
                }
                isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {isSpecialNum}");
            }
        }
    }
}