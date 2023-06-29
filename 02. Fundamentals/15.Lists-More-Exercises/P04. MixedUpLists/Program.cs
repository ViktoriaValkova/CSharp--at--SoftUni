using System.IO.Enumeration;

namespace P04._MixedUpLists
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
            secondLine.Reverse();
            List<int> resultingList = new List<int>();
            MixTwoLines(firstLine, secondLine, resultingList);

            int[] constrains = new int[2];
            FindConstrains(firstLine, secondLine, constrains);
            Array.Sort(constrains);

            resultingList.RemoveAll(num => num <= constrains[0] || num >= constrains[1]);
            resultingList.Sort();
            Console.WriteLine(string.Join(" ",resultingList));

        }

         static void FindConstrains(List<int> firstLine, List<int> secondLine, int[] constrains)
         {
             List<int> longerLine = FindLongerLine(firstLine, secondLine);
             
                constrains[0] = longerLine[^1];
                constrains[1]  = longerLine[^2];
         }

          static List<int> FindLongerLine(List<int> firstLine, List<int> secondLine)
          {
              if (firstLine.Count > secondLine.Count)
              {
                  return firstLine;
              }
              return secondLine;
          }

         static void MixTwoLines(List<int> firstLine, List<int> secondLine, List<int> resultingList)
        {
            for (int i = 0; i < Math.Min(firstLine.Count, secondLine.Count); i++)
            {
                resultingList.Add(firstLine[i]);
                resultingList.Add(secondLine[i]);
            }
        }
    }
}