namespace P02.EnglishNameOfTheLastDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int lastDigit = number % 10;
            // string num =Console.ReadLine();
            // int digit = int.Parse(num[num.Length-1].ToString());
            if (lastDigit == 1)  // or with swich case
            {
                Console.WriteLine("one");
            }
            if (lastDigit == 2)
            {
                Console.WriteLine("two");
            }
            if (lastDigit == 3)
            {
                Console.WriteLine("three");
            }
            if (lastDigit == 4)
            {
                Console.WriteLine("four");
            }
            if (lastDigit ==5)
            {
                Console.WriteLine("five");
            }
            if (lastDigit == 6)
            {
                Console.WriteLine("six");
            }
            if (lastDigit == 7)
            {
                Console.WriteLine("seven");
            }
            if (lastDigit == 8)
            {
                Console.WriteLine("eight");
            }
            if (lastDigit == 9)
            {
                Console.WriteLine("nine");
            }
            if (lastDigit == 0)
            {
                Console.WriteLine("zero");
            }
        }
    }
}