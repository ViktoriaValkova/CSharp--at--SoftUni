using System;
using System.Diagnostics.CodeAnalysis;

namespace P02.Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int doctors = 7;
            int patientsUntreated = 0;
            int patientsTreated = 0;
            int sumPatients = 0;
            for (int i= 1; i <= days; i++) 
            {
               if (i%3 == 0 && patientsUntreated > patientsTreated)
                {
                    doctors++; 
                }
                
                int patientsForTheDay = int.Parse(Console.ReadLine());
                sumPatients += patientsForTheDay;
           
                if (patientsForTheDay > doctors)
                {
                    patientsUntreated += patientsForTheDay - doctors; 
                }
                patientsTreated += patientsForTheDay - patientsUntreated;
           
            }
            Console.WriteLine($"Treated patients: {sumPatients-patientsUntreated}.");
          
            Console.WriteLine($"Untreated patients: {patientsUntreated}.");
        }
    }
}
