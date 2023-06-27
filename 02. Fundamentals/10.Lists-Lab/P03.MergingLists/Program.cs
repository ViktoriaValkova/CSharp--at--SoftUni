namespace P03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstLine = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondLine = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> resulltingList = new List<int>();

            for (int i = 0; i < Math.Max(firstLine.Count, secondLine.Count); i++)
            {
                if (i < firstLine.Count)
                {
                    resulltingList.Add(firstLine[i]);
                }
                if (i < secondLine.Count)
                {
                    resulltingList.Add(secondLine[i]);
                }

            }

            Console.WriteLine(string.Join(" ", resulltingList));
        }

    }
}