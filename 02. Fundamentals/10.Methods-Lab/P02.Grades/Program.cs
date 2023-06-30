namespace P02.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            GradeCheck(double.Parse(Console.ReadLine()));
        }

        private static void GradeCheck(double grade)
        {
            string gradeInWords = string.Empty;
            if (grade >= 5.5) 
            {
                gradeInWords = "Excellent";
            }
            else if (grade >= 4.5)
            {
                gradeInWords = "Very good";
                    }
            else if (grade >= 3.5)
            {
                gradeInWords = "Good";
            }
            else if (grade > 3)
            {
                gradeInWords = "Poor";
            }
            else
            {
                gradeInWords = "Fail";
            }
            Console.WriteLine(gradeInWords);


        }
    }
}