namespace P07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();  
            int repeatCnt = int.Parse(Console.ReadLine());

            Console.WriteLine(ResultingString(input,repeatCnt));
        }
         static string ResultingString(string input,int repeatCnt)
        {
            string newString = string.Empty;
            for (int i = 0; i < repeatCnt; i++)
            {
                newString += input; 
            }
            return newString;
        }
    }
}