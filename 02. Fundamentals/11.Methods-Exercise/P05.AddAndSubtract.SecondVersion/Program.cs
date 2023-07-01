namespace P05.AddAndSubtract._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int result = SubstractThirdNum(SumOfFirstTwo(firstNum, secondNum), thirdNum);
            Console.WriteLine(result);

        }
        static int SumOfFirstTwo(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
        static int SubstractThirdNum(int sum, int thirdNum)
        {
            return sum - thirdNum;
        }
    }
}