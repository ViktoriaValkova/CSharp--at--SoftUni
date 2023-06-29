namespace P08.AnonymousThreat
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
            startIndex = ValidateStartIndex(startIndex);
            endIndex = ValidateEndIndex(data.Count, endIndex);

            int addingCount = endIndex - startIndex;
            for (int i = 0; i < addingCount; i++)
            {
                data[startIndex] += data[startIndex + 1];
                data.RemoveAt(startIndex + 1);
            }
        }
        static int ValidateStartIndex(int startIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }

            return startIndex;
        }
        static int ValidateEndIndex(int dataCount, int endIndex)
        {
            if (endIndex >= dataCount)
            {
                endIndex = dataCount - 1;
            }
            return endIndex;
        }
        static void DivideElements(List<string> data, int index, int partitions)
        {
            string currentElement = data[index];
            data.RemoveAt(index);
            int partLength = currentElement.Length / partitions;

            List<string> tempList = new List<string>();
            int currentStartIndex = 0;
            for (int i = 0; i < partitions - 1; i++)
            {
                string currentPart = currentElement.Substring(currentStartIndex, partLength);
                tempList.Add(currentPart);
                currentStartIndex += partLength;
            }
            string lastPart = currentElement.Substring(currentStartIndex);
            tempList.Add(lastPart);
            data.InsertRange(index, tempList);
        }

    }
}