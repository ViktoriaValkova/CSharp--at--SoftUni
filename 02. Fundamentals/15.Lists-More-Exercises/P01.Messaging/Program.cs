using System.Diagnostics;

namespace P01.Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers= Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string text = Console.ReadLine();
            List<char> tempList = new List<char>();
            for (int i = 0; i < numbers.Count; i++)
            {
                int sumDigits = SumDigitsOfNumber(numbers[i]);
                int index = ValidateIndex(sumDigits, text.Length);
                tempList.Add(text[index]);
                text = text.Remove(index,1);
            }

            Console.WriteLine(string.Join("",tempList));
        }

         static int ValidateIndex(int index, int symbolsCount)
        {
            if (index > symbolsCount)
            {
                index %= symbolsCount;
            }
            return index;

        }

        static int SumDigitsOfNumber(int number)
         {
             int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}