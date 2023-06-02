using System;

namespace P08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double sumMarks = 0;
            int excluded = 0;
            int grade = 1;
            while (grade <= 12)
            {

               double mark = double.Parse(Console.ReadLine());
                if (mark < 4.00)
                {
                    excluded++;
                    if (excluded > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        break;
                    }
                    continue;
                }
                sumMarks += mark;
                grade++;

                if (grade > 12)
                {
                    Console.WriteLine($"{name} graduated. Average grade: {sumMarks / 12:f2}");
                    break;
                }
               
            }

        }
    }
}