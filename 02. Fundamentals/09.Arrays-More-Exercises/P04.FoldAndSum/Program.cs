namespace P04.FoldAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initialArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] firstRow = new int[initialArr.Length / 2];
            int[] secondRow = new int[firstRow.Length];

            for (int i = 0; i < firstRow.Length/2; i++) 
            {
                firstRow[i] = initialArr[i+1];

            }
        }
    }
}