using System;

namespace P01.Alternative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "Stop")
            {
                Console.WriteLine(input);
            }
        }// this method is safe guarding against endless cycle, because it makes sure
        // the input isnt forgotten
    }
}
