namespace P11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            char operatorSymbol = char.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(firstNumber, operatorSymbol, secondNumber));

        }
        static double Calculate(double firstNumber, char operatorSymbol, double secondNumber)
        {
            double result = 0;
            switch (operatorSymbol)
            {
                case '/': result = firstNumber / secondNumber; break;
                case '*':
                    result = firstNumber * secondNumber;
                    break; ;
                case '+':
                    result = firstNumber + secondNumber;
                    break; ;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
            }
            return result;
        }
    }
}