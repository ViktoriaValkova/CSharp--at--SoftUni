using System.Threading.Channels;

namespace P03.TakeSkipRope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();
            List<char> nonNumbers = new List<char>();

            DivideString(input, numbers, nonNumbers);

            List<int> oddNums = new List<int>();
            List<int> evenNums = new List<int>();
            DivideNumsInEvenAndOdd(numbers, oddNums,evenNums);
            List<string> result = TakeCharactersFromString(nonNumbers, evenNums, oddNums);
            Console.WriteLine(string.Join("",result));
        }

         static List<string> TakeCharactersFromString(List<char> nonNumbers, List<int> evenNums, List<int> oddNums)
         {
             List<string> result = new List<string>();
            for (int i = 0; i < evenNums.Count-1; i++)
            {
                int countToTake = evenNums[i];
                int countToSkip = oddNums[i];

                string currentPartOfString = string.Join("",nonNumbers.GetRange(0, countToTake));
                result.Add(currentPartOfString);
                nonNumbers.RemoveRange(0,countToTake+countToSkip);
            }
            AddLastPartOfString (nonNumbers,evenNums, result);
            return result;
        }

          static void AddLastPartOfString(List<char> nonNumbers, List<int> evenNums, List<string> result)
         {
             if (evenNums[^1] < nonNumbers.Count)
             {
                result.Add(string.Join("", nonNumbers.GetRange(0, evenNums[^1])));
             }
             else
            {
                result.Add(string.Join("",nonNumbers.GetRange(0,nonNumbers.Count) ));
            }
         }

         static void DivideString(string? input, List<int> numbers, List<char> nonNumbers)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    int digit = int.Parse(input[i].ToString());
                    numbers.Add(digit);
                }
                else
                {
                    nonNumbers.Add(input[i]);
                }
            }
        }

        static void DivideNumsInEvenAndOdd(List<int> numbers, List<int> oddNums, List<int> evenNums)
        {
            for (int i= 0; i<numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    evenNums.Add(numbers[i]);
                }
                else
                {
                    oddNums.Add(numbers[i]);
                }
            }

        }

    }
}