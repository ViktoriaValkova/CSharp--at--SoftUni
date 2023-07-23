using System.Security.Cryptography;

namespace P01.ExtractPersonInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string name = string.Empty;
                string age = string.Empty;
                string input = Console.ReadLine();

                for (int j = 0; j < input.Length; j++)
                {
                    int startNameIndex = input.IndexOf('@')+1;
                    int endNameIndex = input.IndexOf('|');
                    int ageStartIndex = input.IndexOf('#')+1;
                    int endAgeStartIndex = input.IndexOf('*');
                    name = input.Substring(startNameIndex, endNameIndex - startNameIndex);
                    age = input.Substring(ageStartIndex, endAgeStartIndex - ageStartIndex);
                }

                Console.WriteLine($"{name} is {age} years old.");

            }


        }
    }
}