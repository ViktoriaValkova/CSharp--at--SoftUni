using System;

namespace P04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();  // other way  2:25:00
            string[] words = input.Split();
            //for (int i = words.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(words[i] + " ");
            //}
               Array.Reverse(words);
               Console.WriteLine(string.Join(" ", words));
            
        }
    }
}