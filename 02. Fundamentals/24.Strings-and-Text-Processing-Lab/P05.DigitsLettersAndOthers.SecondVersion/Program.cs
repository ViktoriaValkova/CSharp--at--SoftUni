namespace P05.DigitsLettersAndOthers.SecondVersion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] digits = text.Where(ch=>char.IsDigit(ch)).ToArray();
            char[] letters = text.Where(ch=>char.IsLetter(ch)).ToArray();
            char[] others = text.Where(ch => !char.IsLetterOrDigit(ch)).ToArray();

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}