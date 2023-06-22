namespace P08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numberKegs = byte.Parse(Console.ReadLine());
            double biggestKen = double.MinValue;
            string result = string.Empty;
            string model = string.Empty;
            for (int i = 0; i < numberKegs; i++)
            {
                model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * radius * radius * height;
                if (volume > biggestKen)
                {
                    result = model;
                    biggestKen = volume;
                }
            }
            Console.WriteLine(result);
        }
    }
}