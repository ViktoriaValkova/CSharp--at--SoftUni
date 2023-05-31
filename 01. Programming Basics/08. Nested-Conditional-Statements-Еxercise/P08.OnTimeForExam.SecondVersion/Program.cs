using System;
namespace P09._2.OnTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int hourOfExam = int.Parse(Console.ReadLine());
            int minutesOfExam = int.Parse(Console.ReadLine());  
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minutesOfArrival = int.Parse(Console.ReadLine());
            minutesOfExam += 60 * hourOfExam; 
            minutesOfArrival += 60 * hourOfArrival;
            int timeDifferenceWhenEarly = minutesOfExam - minutesOfArrival;
            if (minutesOfExam < minutesOfArrival) // late 
            {
                Console.WriteLine("Late");
                int timeBeingLate = minutesOfArrival - minutesOfExam;
                int hoursBeingLate = timeBeingLate / 60;
                int minutesBeingLate = timeBeingLate % 60;
                if (hoursBeingLate > 0) //more than 1 h late
                {                   
                        Console.WriteLine($"{hoursBeingLate}:{minutesBeingLate:d2} hours after the start");      // d2 makes sure there are 2 digits         
                }
                else  // less than 1 hour late 
                {
                    Console.WriteLine($"{minutesBeingLate:f0} minutes after the start");
                }
            }
            else if (minutesOfArrival<minutesOfExam-30) // early               
            {
                Console.WriteLine("Early");
                
                if (timeDifferenceWhenEarly < 60) // early but less then 1 h 
                {
                    Console.WriteLine($"{timeDifferenceWhenEarly:f0} minutes before the start");
                }
                else  //more than 1 h early
                {
                    int hoursBeingEarly = timeDifferenceWhenEarly / 60;
                    int minutesBeingEarly = timeDifferenceWhenEarly % 60;
                    Console.WriteLine($"{hoursBeingEarly}:{minutesBeingEarly:d2} hours before the start");
                }  
            }
            else  // on time   but before exam            
            {
                Console.WriteLine("on time");              
                Console.WriteLine($"{timeDifferenceWhenEarly:f0} minutes before the start");               
            }
        }
    }
}