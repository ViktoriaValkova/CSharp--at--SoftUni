namespace P01.SoftUniReception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeEff = int.Parse(Console.ReadLine());
            int secondEmployeeEff = int.Parse(Console.ReadLine());
            int thirdEmployeeEff = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            int hoursCnt = 0;
            int studentsPerHour = firstEmployeeEff + secondEmployeeEff + thirdEmployeeEff; ;
            while(studentsCount > 0)
            {
                hoursCnt++;
                if (hoursCnt % 4 == 0)
                {
                    continue;
                }
                studentsCount -= studentsPerHour; 
            }
            Console.WriteLine($"Time needed: {hoursCnt}h.");
        }
    }
}