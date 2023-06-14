using System;

namespace P06.TheMostPowerfulWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = string.Empty;        
            int maxPoints = 0;
            string powerefulWord = string.Empty;
            while ((word = Console.ReadLine()) != "End of words")
            {
                int sumPoints = 0;
                for (int i = 0; i < word.Length; i++)
                {
                      sumPoints += word[i];                            
                }
                if (word[0] == 'a' || word[0] == 'e'|| word[0] == 'i'|| word[0] == 'o' || word[0] == 'u' || word[0] == 'y'
                  || word[0] == 'A' || word[0] == 'E' || word[0] == 'I' || word[0] == 'O'|| word[0] == 'U' || word[0] == 'Y' )                        
                    {
                        sumPoints *= word.Length;
                    }     
                else
                   sumPoints /=word.Length;

                if (sumPoints > maxPoints)
                {
                    maxPoints = sumPoints;
                    powerefulWord = word;
                }
            }
            Console.WriteLine($"The most powerful word is {powerefulWord} - {maxPoints}");
        }
    }
}
