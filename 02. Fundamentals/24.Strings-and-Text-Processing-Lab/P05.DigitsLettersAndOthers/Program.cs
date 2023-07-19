using System.Text;

namespace P05.DigitsLettersAndOthers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().ToCharArray();
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder others = new StringBuilder();

            foreach (char ch in text)
            {

                if (char.IsLetter(ch))
                {
                    letters.Append(ch);
                }
                else if (char.IsDigit(ch))
                {
                    digits.Append(ch);
                }
                else
                {
                    others.Append(ch);
                }

                Console.WriteLine(string.Join("", digits));
                Console.WriteLine(string.Join("", letters));
                Console.WriteLine(string.Join("", others));

            }
        }
    }
}