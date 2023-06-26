namespace P05.LongestIncreasingSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initialArr = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToArray();

            int[] increasingSeq;
            int[] length = new int[initialArr.Length];
            int[] previous = new int[initialArr.Length];

            int lastIndex = -1;
            int maxLength = 0;

            for (int i = 0; i < initialArr.Length - 1; i++)
            {
                length[i] = 1;
                previous[i] = -1;


                for (int j = 0; j < i; j++)
                {
                    if (initialArr[j] < initialArr[i]
                            && length[j] >= length[i])
                    {
                        length[i] = 1 + length[j];
                    }
                }
                if (length[i] > maxLength)
                {
                    maxLength = length[i];
                    lastIndex = i;
                }
            }
            increasingSeq = new int[maxLength];
            for (int k = 0; k < maxLength; k++)
            {
                increasingSeq[k] = initialArr[lastIndex];
                lastIndex = previous[lastIndex];
            }
            Array.Reverse(increasingSeq);
            Console.WriteLine(string.Join(' ', increasingSeq));
        }
    }
}