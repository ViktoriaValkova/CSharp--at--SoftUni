namespace P03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());
            string[] firstLine = new string[numberLines];
            string[] secondLine = new string[numberLines]; 
            for (int i = 0; i < numberLines; i++)
            {
                string[] currentString = Console.ReadLine().Split();
                if (i % 2 == 0) 
                {
                    firstLine[i] = currentString[0];
                    secondLine[i] = currentString[1];
                }
                else
                {
                    firstLine[i] = currentString[1];
                    secondLine[i] = currentString[0];
                }
            }
            Console.WriteLine(string.Join(" ",firstLine));
            Console.WriteLine(string.Join(" ",secondLine));
        }
    }
}