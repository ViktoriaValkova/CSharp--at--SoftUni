namespace P01.LettersChangeNumbers
{
    internal class Program
    {
        //A12b s17G
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double finalSum = 0;

            foreach (string str in input)
            {
                int num = int.Parse(str.Substring(1,str.Length-2).ToString()); // or str[1..^1]
                double firstLetter = int.Parse((char.ToUpper(str[0]) -64).ToString());
                int secondLetter = int.Parse((char.ToUpper(str[^1]) -64).ToString());
                double currentSum = 0; 
                if (char.IsUpper(str[0]))
                {
                    currentSum += num / firstLetter;
                }
                else if (char.IsLower(str[0]))
                {
                    currentSum += num * firstLetter;
                }
                if (char.IsUpper(str[^1]))
                {
                    currentSum -= secondLetter;
                }
                else if (char.IsLower(str[^1]))
                {
                    currentSum += secondLetter;
                }

                finalSum += currentSum;
            }
                    Console.WriteLine($"{finalSum:f2}");
        }
    }
}