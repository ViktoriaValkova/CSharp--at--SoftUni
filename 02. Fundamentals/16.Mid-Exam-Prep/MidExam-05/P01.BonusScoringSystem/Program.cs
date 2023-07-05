namespace P01.BonusScoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentCnt = int.Parse(Console.ReadLine());
            int lecturesCnt = int.Parse(Console.ReadLine());
            int addBonus = int.Parse(Console.ReadLine());

            double bestBonus = 0;
            int bestAttendance = 0;
            for (int i = 0; i < studentCnt; i++)
            {
                int attendanceOfStudent = int.Parse(Console.ReadLine());

                double totalBonus = (double) attendanceOfStudent / lecturesCnt * (5 + addBonus);
                
                if (totalBonus > bestBonus)
                {
                    bestBonus = totalBonus;
                    bestAttendance = attendanceOfStudent;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(bestBonus)}.");
            Console.WriteLine($"The student has attended {bestAttendance} lectures.");
        }
    }
}