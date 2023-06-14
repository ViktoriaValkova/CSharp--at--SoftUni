using System;

namespace P04.TrekkingMania    //  28/29.03.2020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int .Parse(Console.ReadLine());
            double procentMussala =0;
            double procentMonblanc = 0;
            double procentKilimanjaro = 0;
            double procentK2 = 0;
            double procentEverest = 0;
            int allTourists = 0;
            for (int i = 1;  i <= groupCount; i++)
            {
                
                int peopleCount = int .Parse(Console.ReadLine());
                allTourists += peopleCount; // can be done after the for loop, as sum of all groups
                if (peopleCount <= 5)       // so not to slow down the program further.
                { 
                    procentMussala += peopleCount;
                }
                else if (peopleCount <= 12)
                {
                    procentMonblanc += peopleCount;
                }
                else if (peopleCount <= 25)
                {
                    procentKilimanjaro += peopleCount;
                                    }
                else if (peopleCount <= 40)
                {
                    procentK2 += peopleCount;
                }
                else
                {
                    procentEverest += peopleCount;
                }
            }
            Console.WriteLine($"{procentMussala/allTourists*100:f2}%");
            Console.WriteLine($"{procentMonblanc / allTourists * 100:f2}%");
            Console.WriteLine($"{procentKilimanjaro / allTourists * 100:f2}%");
            Console.WriteLine($"{procentK2 / allTourists * 100:f2}%");
            Console.WriteLine($"{procentEverest / allTourists * 100:f2}%");
        }
    }
}
