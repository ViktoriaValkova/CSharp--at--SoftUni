using System.Text;

namespace P03.TreasureFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] keyNums = Console.ReadLine().Split().Select(num => int.Parse(num)).ToArray();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "find")
            {
                input = DecryptMessage(input, keyNums);
                string coordinates = FindCoordinates(input);
                string treasure = FindTreasure(input);
                Console.WriteLine($"Found {treasure} at {coordinates}");
            }
        }

        private static string FindCoordinates(string input)
        {
            string coordinates = string.Empty;
            int coordStartIndex = input.IndexOf('<') + 1;
            int coordEndIndex = input.IndexOf('>');
            return coordinates = input.Substring(coordStartIndex, coordEndIndex - coordStartIndex);
        }

        private static string FindTreasure(string input)
        {
            string treasure = string.Empty;
            int treasureStartIndex = input.IndexOf('&') + 1;
            int treasureEndIndex = input.LastIndexOf('&');
            return treasure = input.Substring(treasureStartIndex, treasureEndIndex - treasureStartIndex);
        }

        private static string DecryptMessage(string input, int[] keyNums)
        {
            int numIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                char newCh = (char)(ch - keyNums[numIndex]);
                input = input.Remove(i, 1);
                input = input.Insert(i, newCh.ToString());
                numIndex++;
                if (numIndex == keyNums.Length)
                {
                    numIndex = 0;
                }
            }
            return input;
        }
    }
}