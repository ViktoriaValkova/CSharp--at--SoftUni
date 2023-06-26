namespace P03.RecursiveFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seqNum = int.Parse(Console.ReadLine());

            int[] sequence = new int[seqNum];
            sequence[0] = 1;

            if (seqNum > 1)
            {
                sequence[1] = 1;
                for (int i = 2; i < seqNum; i++)
                {
                    sequence[i] = sequence[i - 1] + sequence[i - 2];
                }
            }
                Console.WriteLine(sequence[seqNum - 1]);         
        }
    }
}