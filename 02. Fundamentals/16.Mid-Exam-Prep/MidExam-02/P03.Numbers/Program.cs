using System.ComponentModel.Design;
using System.Threading.Channels;

namespace P03.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            double averageValue = numbers.Average();

            if (!CheckForTopNumbers(numbers, averageValue))
            {
                Console.WriteLine("No");
                return;
            }
            numbers.Sort();
            numbers.Reverse();
            for (var i = 0; i <5; i++)
            {
                if (numbers[i] > averageValue)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
            
        }

         static bool CheckForTopNumbers(List<int> numbers, double averageValue)
        {
            foreach (int number in numbers)
            {
                if (number > averageValue)
                {
                    return true;
                }
            }
            return false;
        }
    }
}