using System;

namespace P02.Alternative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int treated = 0;
            int untreated = 0;
            int doctors = 7; 
            for (int i = 1; i <=days; i++)
            {
                if (i % 3 == 0 && treated < untreated)
                {
                    doctors++; 
                }
                int patients = int.Parse(Console.ReadLine());
                if (patients <= doctors)
                {
                    treated += patients;
                    
                }
                else
                {
                    treated += doctors;
                    untreated += patients - doctors;
                }
            }
            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {untreated}.");
        }
    }
}
