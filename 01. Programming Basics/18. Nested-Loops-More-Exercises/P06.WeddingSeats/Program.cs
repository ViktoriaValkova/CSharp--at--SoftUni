using System;

namespace P06.WeddingSeats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int rowsFirstSector = int.Parse(Console.ReadLine());// every following sector has one more row
            int rows = rowsFirstSector;     // can be skipped, and only the above used
            int seatsOddRows = int.Parse(Console.ReadLine()); // seatsEvenRows = even+2 

            int counter = 0;

            for (char i = 'A'; i <= lastSector; i++)
            {
                for (int j = 1; j <= rows; j++)
                {

                    if (j % 2 != 0)
                    {

                        for (char k = 'a'; k < 97 + seatsOddRows; k++)
                        {

                            Console.WriteLine($"{i}{j}{k}");
                            counter++;
                        }
                    }

                    if (j % 2 == 0)
                    {

                        for (char k = 'a'; k < 97 + seatsOddRows+2; k++) // or k < 'a' + seatsOddRows
                        {

                            Console.WriteLine($"{i}{j}{k}");
                            counter++;
                        }
                    }

                }
                rows++;
            }
            Console.WriteLine(counter);
        }
    }
}
