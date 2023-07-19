namespace P03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine(); 
            string wholeString = Console.ReadLine();

            while (wholeString.Contains(wordToRemove))
            {
                int startIndex = wholeString.IndexOf(wordToRemove);
               wholeString= wholeString.Remove(startIndex,wordToRemove.Length);
               // or can be done with Replace(wordToRemove,string.Empty)
            }

            Console.WriteLine(wholeString);
        }
    }
}