namespace P01.Encrypt_Sort_AndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            string[] words = new string[arraySize];

            for (int j = 0; j < words.Length; j++)
            {
                words[j] = Console.ReadLine();

            }
            int[] coded = new int[arraySize];
            for (int k = 0; k < words.Length; k++)
            {
                string word = words[k];
                int codedSum = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i'
                       || word[i] == 'o' || word[i] == 'u'
                       || word[i] == 'A' || word[i] == 'E' || word[i] == 'I'
                       || word[i] == 'O' || word[i] == 'U')
                    {
                        codedSum += word[i] * word.Length;
                    }
                    else
                    {
                        codedSum += word[i] / word.Length;
                    }

                }
                coded[k] = codedSum;
            }
            Array.Sort(coded);
            for (int i =0; i <coded.Length; i++)  // can be done with foreach 
            {
                Console.WriteLine(coded[i]);
            }
        }
    }
}