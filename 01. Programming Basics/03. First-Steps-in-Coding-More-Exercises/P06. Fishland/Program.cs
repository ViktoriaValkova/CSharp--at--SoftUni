using System;
namespace P06._Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double skumriaPrice =  double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double palamudAmmount = double.Parse(Console.ReadLine());   
            double safridAmmount = double.Parse(Console.ReadLine());
            double midiAmmount = double.Parse(Console.ReadLine());
            double palamudPrice = skumriaPrice + skumriaPrice * 0.6;
            double safridPrice = cacaPrice + cacaPrice * 0.8;
            double sum = palamudAmmount * palamudPrice + safridAmmount * safridPrice + midiAmmount * 7.5;
            Console.WriteLine("{0:f2}", sum);

        }
    }
}