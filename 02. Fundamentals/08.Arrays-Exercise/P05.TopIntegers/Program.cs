namespace P05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
       
            for (int i = 0; i < input.Length; i++)
            {
                    bool isSmaller = false;
                for (int j = i+1; j <input.Length; j++)
                {

                    if (input[i] <= input[j])  // <= instead of < 
                    {
                      
                        isSmaller = true;
                    }
                }
                if (!isSmaller)
                {
                    Console.Write(input[i] + " ");
                }
            }
        }
    }
}