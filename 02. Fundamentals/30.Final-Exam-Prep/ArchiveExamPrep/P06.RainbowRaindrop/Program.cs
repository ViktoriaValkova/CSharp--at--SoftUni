using System; 
using System.Linq;
using System.Collections.Generic;
namespace P06.RainbowRaindrop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Raindrop> rainbowRaindrops = new List<Raindrop>();
            while ((input = Console.ReadLine()) != "End")
            {
                string[] values = input.Split().ToArray();
                if (values.Length < 4)
                {
                    continue;
                }

                double volume=0;
                int redValue = 0, greenValue = 0, blueValue=0;

                if (!double.TryParse(values[0], out volume) ||
                    !int.TryParse(values[1], out redValue) ||
                    !int.TryParse(values[2], out greenValue) ||
                    !int.TryParse(values[3], out blueValue))
                {
                    continue;
                }

                CheckValue(ref greenValue);
                CheckValue(ref blueValue);
                CheckValue(ref redValue);
                Raindrop currentRaindrop = new Raindrop(volume, redValue, greenValue, blueValue);
                if (CheckForRainbow(currentRaindrop))
                {
                    rainbowRaindrops.Add(currentRaindrop);
                }
            }

            Console.WriteLine($"Rainbow Raindrops: {rainbowRaindrops.Count}");
            rainbowRaindrops = rainbowRaindrops.OrderBy(r => r.Volume).ToList();
            int counter = 1;
            foreach (Raindrop raindrop in rainbowRaindrops)
            {
                Console.WriteLine($"{counter}. {raindrop}");
                counter++;
            }
        }

        static void CheckValue(ref int value)
        {
            if (value < 0 || value > 255)
            {
                value = 0;
            }
        }
        static bool CheckForRainbow(Raindrop currentRaindrop)
        {
            if (currentRaindrop.BlueValue > 200 && currentRaindrop.RedValue < 100 && currentRaindrop.GreenValue < 100
                || currentRaindrop.GreenValue > 200 && currentRaindrop.RedValue < 100 && currentRaindrop.BlueValue < 100
                || currentRaindrop.RedValue > 200 && currentRaindrop.BlueValue < 100 && currentRaindrop.GreenValue < 100)
            {
                return true;
            }
            return false;
        }
    }
    class Raindrop
    {
        public Raindrop(double volume, int redValue, int greenValue, int blueValue)
        {
            Volume = volume;
            RedValue = redValue;
            GreenValue = greenValue;
            BlueValue = blueValue;
        }

        public double Volume { get; set; }
        public int RedValue { get; set; }
        public int GreenValue { get; set; }
        public int BlueValue { get; set; }

        public override string ToString()
        {
            return $"V:{this.Volume:f2} -> R:{this.RedValue} G:{this.GreenValue} B:{this.BlueValue}";
        }
    }
}