namespace P03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            ListOfChars(firstChar, secondChar);
        }
        static void ListOfChars(char firstChar, char secondChar)
        {
            if (secondChar < firstChar)
            {
                char placeHolder = firstChar;
                firstChar = secondChar;
                secondChar = placeHolder;
            }
            for (int i = firstChar + 1; i < secondChar; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}