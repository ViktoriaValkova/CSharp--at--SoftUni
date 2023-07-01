namespace P01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            SmallesIntegerOfThree(numberOne, numberTwo, numberThree);
        }
        static void SmallesIntegerOfThree(int numberOne, int numberTwo, int numberThree)
        {
            if (numberOne < numberTwo && numberOne < numberThree)
            {
                Console.WriteLine(numberOne);
            }
            else if (numberTwo < numberOne && numberTwo < numberThree)
            {
                Console.WriteLine(numberTwo);
            }
            else
            {
                Console.WriteLine(numberThree);
            }

        }
    }
}