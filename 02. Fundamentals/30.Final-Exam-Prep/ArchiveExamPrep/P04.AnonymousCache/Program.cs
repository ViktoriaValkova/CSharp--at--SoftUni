using System.Reflection.Metadata;
using System.Security.Cryptography;
using System;
using System.Linq;
using System.Collections.Generic;

namespace P04.AnonymousCache
{
     class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Data>> existingData = new Dictionary<string, List<Data>>();
            Dictionary<string, List<Data>> cachedLIst = new Dictionary<string, List<Data>>();
            ;

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "thetinggoesskrra")
            {
                string[] info = input.Split();
                if (info.Length == 1)
                {
                    if (!cachedLIst.ContainsKey(info[0]))
                    {
                    existingData[info[0]] = new List<Data>();
                    }
                    else
                    {
                        var foundData = cachedLIst[info[0]];
                        existingData.Add(info[0],foundData);
                    }
                }
                else
                {
                    info = input.Split(new char[] { '-', '>', '|', ' '}, StringSplitOptions.RemoveEmptyEntries);
                   string key = info[0];
                    int size = int.Parse(info[1]);
                    string set = info[2];

                    if (!existingData.ContainsKey(set))
                    {
                        if (!cachedLIst.ContainsKey(set))
                        {
                        cachedLIst[set] = new List<Data>();
                        }
                        cachedLIst[set].Add(new Data(key,size));
                    }
                    else
                    {
                        existingData[set].Add(new Data(key,size));
                    }
                }
            }
            if (existingData.Count == 0)
            {
                return;
            }
            // create a new kvp by getting the key and the sum of the object.Size // deleted 
            long bestSum = long.MinValue;
            string bestSet = string.Empty;
            foreach (var kvp in existingData)
            {
                long sum = kvp.Value.Sum(d => d.Size);
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestSet = kvp.Key;
                }
            }

            Console.WriteLine($"Data Set: {bestSet}, Total Size: {bestSum}");
            var resultingSet = existingData[bestSet];
            Console.WriteLine(string.Join("\n", resultingSet));

        }
    }
     class Data
    {
        public Data(string key, long size)
        {
            Key = key;
            Size = size;

        }
        public string Key { get; set; }
        public long Size { get; set; }
        public override string ToString()
        {
            return $"$.{this.Key}";
        }
    }
}