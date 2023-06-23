using System.Diagnostics.CodeAnalysis;

namespace P06.BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
int sumLeft = 0;
            int sumRight = 0;
            bool isBalanced = true;
            int bracketCounter = 0;
            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();
                char.TryParse(input, out char currentChar);
                if (currentChar == '(' || currentChar == ')')
                {
                    bracketCounter++;
                }
                if (currentChar == '(')
                {
                    sumLeft ++;
                }
                else if (currentChar == ')')
                {
                    sumRight ++;
                    if (bracketCounter % 2 != 0)
                    {
                        isBalanced = false;
                    }
                }
            }
            if (sumRight != sumLeft)
            {
                isBalanced = false;
            }
            if (!isBalanced)
            {
                Console.WriteLine("UNBALANCED");
            }
            else
            {
                Console.WriteLine("BALANCED");
            }

        }
    }
}