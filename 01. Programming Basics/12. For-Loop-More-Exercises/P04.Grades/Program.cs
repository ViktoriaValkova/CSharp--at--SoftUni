using System;

namespace P04.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            int gradeA = 0;
            int gradeB = 0;
            int gradeC = 0;
            int gradeD = 0;
            double sumGrades = 0;
            for (int i = 0; i < numberOfStudents; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                sumGrades += grade;
                if (grade < 3.0)
                {
                    gradeD++;
                }
                else if (grade < 4.0)
                {
                    gradeC++;
                }
                else if (grade < 5.0)
                {
                    gradeB++;
                }
                else
                {
                    gradeA++;
                }
            }
            Console.WriteLine($"Top students: {gradeA * 100.0 / numberOfStudents:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {gradeB * 1.0 / numberOfStudents * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {gradeC * 1.0 / numberOfStudents * 100:f2}%");
            Console.WriteLine($"Fail: {gradeD * 1.0 / numberOfStudents * 100:f2}%");
            Console.WriteLine($"Average: {sumGrades / numberOfStudents:f2}"); ;
        }
    }
}
