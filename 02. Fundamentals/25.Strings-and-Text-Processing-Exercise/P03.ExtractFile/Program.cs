namespace P03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split(@"\").ToArray();

            string fileName = path[^1].Split('.').First();
            string extension = path[^1].Remove(0,fileName.Length+1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}