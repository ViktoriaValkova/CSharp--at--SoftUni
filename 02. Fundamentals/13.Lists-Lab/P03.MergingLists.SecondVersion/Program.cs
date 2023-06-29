namespace P03.MergingLists_SecondVersion
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

            List<int> resultingList = new List<int>();

            for (int i = 0; i < Math.Min(firstLine.Count, secondLine.Count); i++)
            {
                resultingList.Add(firstLine[i]);
                resultingList.Add(secondLine[i]);
            }


            if (secondLine.Count < firstLine.Count)
            {
                resultingList.AddRange(AddRemainingNums(firstLine, secondLine));
            }

            else if (firstLine.Count < secondLine.Count)
            {
                resultingList.AddRange(AddRemainingNums(secondLine, firstLine));
            }
            Console.WriteLine(string.Join(" ", resultingList));
        }

        static List<int> AddRemainingNums(List<int> longerList, List<int> shorterList)
        {
            List<int> result = new List<int>();

            for (int i = shorterList.Count; i < longerList.Count; i++)
            {
                result.Add(longerList[i]);

            }
            return result;
        }
    }
}
