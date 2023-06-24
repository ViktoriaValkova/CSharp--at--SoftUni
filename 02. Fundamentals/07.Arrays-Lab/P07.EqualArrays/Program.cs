using System.Diagnostics.Metrics;

namespace P07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] secondArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            bool notIdentical = false;
            for (int i = 0; i < firstArr.Length; i++)
            {
               if (firstArr[i] != secondArr[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                  notIdentical = true;
                    break;
                }
               else
                {
                    sum += firstArr[i]; 
                }
            }
            if (!notIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            
        }
    }
}