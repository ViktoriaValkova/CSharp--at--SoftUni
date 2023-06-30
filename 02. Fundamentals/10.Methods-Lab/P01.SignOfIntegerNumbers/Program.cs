namespace P01.SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckIfPositive(int.Parse(Console.ReadLine()));
        }
        static void CheckIfPositive (int value)
        {
            if (value > 0)
            {
                Console.WriteLine($"The number {value} is positive.");
            }
            else if (value < 0)
            {
                Console.WriteLine($"The number {value} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {value} is zero. ");
            }
        }
    }
}