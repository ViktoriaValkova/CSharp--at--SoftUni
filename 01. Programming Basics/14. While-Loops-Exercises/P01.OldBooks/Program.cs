
using System;

namespace P01.Alternative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            int counter = 0;
            string currentBook;
            bool isBookRight = false; 
            while ((currentBook = Console.ReadLine()) != "No More Books")
            {
                if (currentBook == favoriteBook)
                {
                    isBookRight = true;
                    break;
                }
                counter++;
            }
            if (isBookRight) 
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
