namespace P04.RefactoringPrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersRange = int.Parse(Console.ReadLine());
            for (int number = 2; number <= numbersRange; number++)
            {
                bool isPrime = true;
                for (int divisor = 2; divisor < number; divisor++)
                {
                    if (number % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.Write($"{number} -> ");
                if (isPrime)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}