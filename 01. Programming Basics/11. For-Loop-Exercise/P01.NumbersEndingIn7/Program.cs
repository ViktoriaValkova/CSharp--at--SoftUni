using System;

namespace P01.NumbersEndingIn7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 7; i <= 997; i+=10)
            {
                            
                  Console.WriteLine(i);
                            }// i can start at 7, because we know the number before that dont end in 7 
            // same logic for i <=997
        }
    }// the step can be ajusted to i+10, then there will be no need for if 
}
