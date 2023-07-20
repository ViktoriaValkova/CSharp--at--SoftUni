using System.ComponentModel.Design;

namespace P02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] twoWords = Console.ReadLine().Split();
            string longer = string.Empty;
            bool areEqual = false;
            if (twoWords[0].Length > twoWords[1].Length)
            {
                longer = twoWords[0];
            }
            else if (twoWords[0].Length < twoWords[1].Length)
            {
                longer = twoWords[1];
            }
            else
            {
                areEqual = true;
                longer = twoWords[1];
            }
            int sum = 0;
            int i = 0;
            for ( ;i < Math.Min(twoWords[0].Length,twoWords[1].Length);i++)
            {
                sum += twoWords[0][i]* twoWords[1][i];
            }
            if (!areEqual)
            {
                for (; i < longer.Length; i++)
                {
                    sum += longer[i]; 
                }
            }

            Console.WriteLine(sum);
        }
    }
}