namespace P01.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firtstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());
            int addition = firtstNum + secondNum;
            int division = addition / thirdNum;
            int multiplication = division * fourthNum;
            Console.WriteLine(multiplication);
            // for defensive programming we should use long type; as int.MaxValue*int.MaxValue will give more than int can handle 
        }
    }
}