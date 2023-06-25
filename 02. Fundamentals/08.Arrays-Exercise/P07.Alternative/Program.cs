namespace P07.Alternative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // similar to original, but without second loop 
            // using i+1 instead of j for the next number 

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int counter = 0;
            int startIndex = 0;
            int maxSequence = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                    if (counter > maxSequence)
                    {
                        maxSequence = counter;
                        startIndex = i;
                    }
                }
                else
                {
                    counter = 0;
                }
            }

            for (int i = 0; i <= maxSequence; i++)
            {

                Console.Write(numbers[startIndex] + " ");
            }

            //

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int startIndexNew = 0;
            int length = 0;
            int bestIndex = 0;
            int bestLength = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    if (length == 0)
                    {
                        startIndex = i; 
                        length++;
                    }
                    else
                    {
                        length++;
                    }
                    if (length > bestLength)
                    {
                        bestIndex = startIndex; 
                        bestLength = length;
                    }
                }
                else
                {
                    length = 0;
                }
            }

            for (int i = bestIndex; i <= bestIndex + bestLength; i++)
            {
                Console.Write(input[i] + " ");
            }

        }
    }
}