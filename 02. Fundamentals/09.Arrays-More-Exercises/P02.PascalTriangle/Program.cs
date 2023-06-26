namespace P02.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberRows = int.Parse(Console.ReadLine());
            int[] firstRow = { 1 };

            for (int i = 1; i < numberRows; i++)
            {

                int[] secondRow = new int[firstRow.Length + 1];
                for (int j = 0; j < secondRow.Length-1; j++)
                {
                    secondRow[j]+= firstRow[j];
                    secondRow[j+1] += firstRow[j];
                }
                Console.WriteLine(string.Join(' ', firstRow));
                firstRow = secondRow;

            }
            Console.WriteLine(string.Join(' ', firstRow));

        }
    }
}