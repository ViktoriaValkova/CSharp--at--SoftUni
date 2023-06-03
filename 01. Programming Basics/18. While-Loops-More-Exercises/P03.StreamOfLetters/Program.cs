using System;
using System.Dynamic;

namespace P03.StreamOfLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            bool gotC = false;
            bool gotN = false;
            bool gotO = false;
            string word = "";
            while ((input = Console.ReadLine()) != "End")
            {
                char newChar = char.Parse(input);
                if (!char.IsLetter(newChar))
                {
                    continue;
                }
                else if (newChar == 'c' && !gotC)
                {
                    gotC = true;
                }
                else if (newChar == 'n' && !gotN)
                {
                    gotN = true;
                }
                else if (newChar == 'o' && !gotO)
                {
                    gotO = true;
                }
                else
                {
                    word += newChar;
                }
                if (gotC && gotN && gotO)
                {
                    
                    gotC = false; gotN = false; gotO = false;
                    Console.Write(word + " ");
                    word = "";
                }
            }
        }
    }
}
