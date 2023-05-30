using System;
namespace newProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double dulzhina = double.Parse(Console.ReadLine());
            double buraNaRed = Math.Floor(dulzhina / 1.2);
            double shirochina = double.Parse(Console.ReadLine()) - 1;
            double redove = Math.Floor(shirochina / 0.7);
            double broiBura = redove * buraNaRed - 3;
            Console.WriteLine(broiBura);
        }
    }
}