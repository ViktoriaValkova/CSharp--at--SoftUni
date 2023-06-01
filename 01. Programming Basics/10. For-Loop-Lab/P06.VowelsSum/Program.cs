﻿using System;

namespace P06.VowelsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();  
            int sum = 0;
            for (int index = 0; index < text.Length; index++)
            {
                char letter = text[index];
                switch (letter)
                {
                    case 'a': sum++; break;
                    case 'e': sum += 2; break;
                    case 'i': sum += 3; break;
                    case 'o': sum +=4; break;
                    case 'u': sum += 5; break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
