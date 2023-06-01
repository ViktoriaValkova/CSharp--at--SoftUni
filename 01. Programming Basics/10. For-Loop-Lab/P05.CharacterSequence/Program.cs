using System;

namespace P05.CharacterSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
             string word = Console.ReadLine();
            for (int index = 0; index < word.Length; index++)
            {
                Console.WriteLine(word[index]);
            }
;
        }
    }
}
