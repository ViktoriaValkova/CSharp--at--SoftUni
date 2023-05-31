using System;
namespace _08._On_Time_for_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examStartingHours = int.Parse(Console.ReadLine());
            int examStartingMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());
            double examTimeInMinutes = examStartingHours * 60 + examStartingMinutes;
            double arrivalInMinutes = (arrivalHour * 60 + arrivalMinutes);
            double differenceInMinutes = arrivalInMinutes - examTimeInMinutes;
            if (differenceInMinutes <= 0 && differenceInMinutes >= -30)
            { Console.WriteLine("On time"); }
            if (differenceInMinutes > 0)
            { Console.WriteLine("Late"); }
            if (differenceInMinutes < -30)
            {
                Console.WriteLine("Early");
            }
            double differenceResultHours = Math.Abs(differenceInMinutes / 60.0);
            double differenceResultMinutes = Math.Abs(differenceInMinutes % 60);
            if (arrivalInMinutes > examTimeInMinutes) // late
            {
                if (differenceResultHours >= 1)
                {
                    if (differenceResultMinutes < 10)
                    {
                        Console.WriteLine($"{Math.Floor(differenceResultHours)}:0{differenceResultMinutes:f0} hours after the start");
                    }
                    else
                    
                        Console.WriteLine($"{Math.Floor(differenceResultHours)}:{differenceResultMinutes:f0} hours after the start");
                    

                }
                if (differenceResultHours < 1)
                
                    Console.WriteLine($"{differenceResultMinutes:f0} minutes after the start");
                
            }
            if (arrivalInMinutes < examTimeInMinutes) // early
            {
                if (differenceResultHours >= 1)
                {
                    if (differenceResultMinutes < 10)
                    
                        Console.WriteLine($"{Math.Floor(differenceResultHours)}:0{differenceResultMinutes:f0} hours before the start");
                    
                    else
                    
                        Console.WriteLine($"{Math.Floor(differenceResultHours)}:{differenceResultMinutes:f0} hours before the start");
                    
                }

                if (differenceResultHours < 1)
                {
                    Console.WriteLine($"{differenceResultMinutes:f0} minutes before the start");
                }
            }

        }
    }
}