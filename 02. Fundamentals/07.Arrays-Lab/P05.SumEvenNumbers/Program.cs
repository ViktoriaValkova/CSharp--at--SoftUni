namespace P05.SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  string input = Console.ReadLine();
               string[] numbersAsString = input.Split();
               int sum = 0;
               for (int i = 0; i < numbersAsString.Length; i++)
               {
                   int currentNum = int.Parse(numbersAsString[i]);
                   if (currentNum % 2 == 0)
                   {
                       sum += currentNum;
                   }
               }
               Console.WriteLine(sum);
            */

            int[] numbers = Console.ReadLine()  // double ? 
            .Split()
            .Select(int.Parse)
            .ToArray();
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)  // can be done with for each 
            {
                int currentNum = numbers[i];
                if (currentNum % 2 == 0)
                {
                    sum += currentNum;
                }
            }
            Console.WriteLine(sum);
        }
    }
}