namespace P06.EqualSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse).ToArray();

            bool elementExists = false;
            int indexOfElement = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += input[j];
                }
                for (int k = i + 1; k < input.Length; k++)
                {
                    rightSum += input[k];
                }
                if (leftSum == rightSum)
                {
                    elementExists = true;
                    indexOfElement = i;
                    break;
                }
            }
            if (elementExists)
            {
                Console.WriteLine(indexOfElement);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}