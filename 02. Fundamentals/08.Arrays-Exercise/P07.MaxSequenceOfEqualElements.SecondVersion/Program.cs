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
        }
    }
}