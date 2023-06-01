using System;

namespace P06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfActor = Console.ReadLine();
            double sumPoints = double.Parse(Console.ReadLine()); 
            int numberOfCritiques = int.Parse(Console.ReadLine());
            
            string nameOfCritique;
            double pointsGiven; 
            for (int i = 0; i < numberOfCritiques; i++)
            {
                  nameOfCritique = Console.ReadLine();
                  pointsGiven = double.Parse(Console.ReadLine());
                sumPoints += pointsGiven * nameOfCritique.Length/2 ;
                if (sumPoints >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {sumPoints:f1}!");
                    break;
                }
            }if (sumPoints < 1250.5)
            {
                Console.WriteLine($"Sorry, {nameOfActor} you need {1250.50 - (sumPoints):f1} more!");
            }            
        }
    }
}
