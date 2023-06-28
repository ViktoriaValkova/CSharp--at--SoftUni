namespace P07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<string> resultingList = new List<string>();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                input[i].Trim();
                string[] currentString = input[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                resultingList.AddRange(currentString);
            }

            Console.WriteLine(string.Join(" ", resultingList));
        }
    }
}