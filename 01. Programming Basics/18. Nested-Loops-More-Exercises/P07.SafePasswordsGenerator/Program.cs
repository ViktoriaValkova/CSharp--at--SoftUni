using System;

namespace P07.SafePasswordsGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxCountPasswords = int.Parse(Console.ReadLine());
            int counter = 0;
            char firstSymbol = (char)35;
            char secondSymbol = (char)64;
            bool isEnough = false;

            for (int x = 1; x <= a; x++)
            {
                for (int y = 1; y <= b; y++)
                {
                    counter++;
                    if (counter > maxCountPasswords)
                    {
                        isEnough = true;
                        break;
                    }
                    Console.Write($"{firstSymbol}{secondSymbol}{x}{y}{secondSymbol}{firstSymbol}|");
                    
                    firstSymbol++;
                    secondSymbol++;
                    if (firstSymbol > 55)
                    {
                        firstSymbol = (char)35;
                    }
                    if (secondSymbol > 96)
                    {
                        secondSymbol = (char)64;
                    }
                    if ((x == a) && (y == b))
                    {
                        isEnough = true ; break;

                    }

                }
                if (isEnough) 
                { break; 
                }
            }
        }

    }
}


