namespace P01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ");

            string[] validUserNames = userNames
                .Where(w => w.Length > 3 && w.Length < 16)
                .ToArray();

            for (int i = 0; i < validUserNames.Length; i++)
            {
                string word = validUserNames[i];
                for (int j = 0; j < word.Length; j++)
                {
                    if (!char.IsLetterOrDigit(word[j]) && word[j] != '-' && word[j] != '_')
                    {
                        validUserNames[i] = "0";
                        break;
                    }
                }
            }
            validUserNames= validUserNames.Where(w=>w!="0").ToArray();

            Console.WriteLine(string.Join("\n", validUserNames));
        }
    }
}