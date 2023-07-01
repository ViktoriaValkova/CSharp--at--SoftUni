namespace P08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            double finalResult = Factorial(firstNum) * 1.0 / Factorial(secondNum);
            Console.WriteLine($"{finalResult:f2}");
        }
        static long Factorial(int num)
        {
            long factorial = num;
            for (int i = 1; i < num; i++)
            {
                factorial *= num - i;
            }
            return factorial;
        }
    }
}