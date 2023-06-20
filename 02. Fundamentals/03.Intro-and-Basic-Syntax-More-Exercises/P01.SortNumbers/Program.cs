namespace P01.SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int[] numbers = { firstNumber, secondNumber, thirdNumber };
            Array.Sort(numbers);
            Array.Reverse(numbers);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}