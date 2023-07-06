using System.Numerics;
using System;
using System.Collections.Generic;

namespace P01.AnonymousDownsite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int websitesCnt = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            List<string> affectedSites = new List<string>();
            decimal totalLoss = 0m;
            for (int i = 0; i < websitesCnt; i++)
            {
                string[] inputData = Console.ReadLine().Split();

                string siteName = inputData[0];
                long siteVisits = long.Parse(inputData[1]);
                decimal commPricePerVisit = decimal.Parse(inputData[2]);

                decimal siteLoss = (decimal)siteVisits * commPricePerVisit; 
                affectedSites.Add(siteName);
                totalLoss += siteLoss;
            }
            BigInteger token = BigInteger.Pow(securityKey, websitesCnt);

            Console.WriteLine(string.Join(Environment.NewLine,affectedSites));
        
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {token}");
        }
    }
}