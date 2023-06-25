namespace P07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                  .Split()
                  .Select(int.Parse).ToArray();

            int maxSequenseNum = 0;
            int maxCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int counter = 0;
                for (int j = i; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (counter > maxCount)
                {
                    maxCount = counter;
                    maxSequenseNum = input[i];
                }
            }
            for (int i = 0; i <maxCount; i++)
            {
                Console.Write(maxSequenseNum + " ");
            }

        }
    }
}