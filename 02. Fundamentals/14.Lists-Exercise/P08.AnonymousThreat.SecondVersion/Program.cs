namespace P08.AnonymousThreat.SecondVersion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine()
     .Split()
     .ToList();

            string input;

            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] instruction = input.Split();
                string command = instruction[0];
                if (command == "merge")
                {
                    int startIndex = int.Parse(instruction[1]);
                    int endIndex = int.Parse(instruction[2]);
                    ConcatenateElements(data, startIndex, endIndex);
                }
                else
                {
                    int index = int.Parse(instruction[1]);
                    int partitions = int.Parse(instruction[2]);
                    DivideElements(data, index, partitions);
                }
            }
            Console.WriteLine(string.Join(" ", data));
        }

        static void ConcatenateElements(List<string> data, int startIndex, int endIndex)
        {
            ValidateIndexes(data.Count, ref startIndex, ref endIndex);
            string concatenatedData = string.Empty;

            for (int i = startIndex; i <= endIndex; i++)
            {
                concatenatedData += data[startIndex]; ;
                data.RemoveAt(startIndex);
            }
            data.Insert(startIndex, concatenatedData);
        }
        static void ValidateIndexes(int count, ref int startIndex, ref int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (startIndex >= count)
            {
                startIndex = count - 1;
            }
            if (endIndex >= count)
            {
                endIndex = count - 1;
            }
            if (endIndex < 0)
            {
                endIndex = 0;
            }
        }

        static void DivideElements(List<string> data, int index, int partitions)
        {
            string currentElement = data[index];
            int substringsLength = currentElement.Length / partitions;
          //  int lastSubstringLength = currentElement.Length - ((partitions - 1) * substringsLength);
              int lastSubstringLength = substringsLength+currentElement.Length % partitions;

            List<string> tempList = new List<string>();

            for (int i = 0; i < partitions; i++)
            {
                int lengthToTake = substringsLength;
                if (i == partitions - 1)
                {
                    lengthToTake = lastSubstringLength;
                }
                char[] partArr = currentElement
                    .Skip(i * substringsLength)
                    .Take(lengthToTake)
                    .ToArray();
                string currentPart = string.Join("", partArr);
                tempList.Add(currentPart);
            }
            data.RemoveAt(index);
            data.InsertRange(index, tempList);
        }
    }
}