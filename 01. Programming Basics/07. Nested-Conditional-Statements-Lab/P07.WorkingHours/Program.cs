using System;
namespace P07.WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int time = int.Parse(Console.ReadLine());
           string day = Console.ReadLine();
            string OpenOrClosed = ""; 
           if (time < 10 ||time > 18)
            {
                OpenOrClosed = "closed";
            }
            else
            {
                switch (day)   
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                    case "Saturday":
                        OpenOrClosed = "open";
                        break;
                    default: OpenOrClosed = "closed";
                        break;
                }
            }
            Console.WriteLine(OpenOrClosed);
        }
    }
}