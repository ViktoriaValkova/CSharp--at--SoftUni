using System;
using System.ComponentModel.Design;

namespace _06._Num_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string operatorSymbol = Console.ReadLine();
            double result = 0.0;
            string OddOrEven = "";
            switch (operatorSymbol)
            {
                case "+":
                    result = n1 + n2;
                    if (result % 2.0 == 0)
                    {
                        Console.WriteLine($"{n1} + {n2} = {result} - even");
                    }
                    else 
                    {
                        Console.WriteLine($"{n1} + {n2} = {result} - odd");
                    }
                    break; 
                case "-":
                    result = n1 - n2;
                    if (result % 2.0 == 0)
                    {
                        Console.WriteLine($"{n1} - {n2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} - {n2} = {result} - odd");
                    }
                    break;
                case "*":
                    result = n1 * n2;
                    if (result % 2.0 == 0)
                    {
                        Console.WriteLine($"{n1} * {n2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} * {n2} = {result} - odd");
                    }
                    break;
               case "/":
                    {
                        if (n2 != 0)
                        {
                            result = n1 / (n2*1.0); // multiply by 1.0 to turn it into double
                            Console.WriteLine($"{n1} / {n2} = {result:f2}");
                        }
                        else
                        {
                            Console.WriteLine($"Cannot divide {n1} by zero");
                        }
                    }
                    break;
                case "%":
                    {
                        if (n2 != 0)
                        {
                            result = n1 % n2;
                            Console.WriteLine($"{n1} % {n2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine($"Cannot divide {n1} by zero");
                        }
                    }
                    break;
            }
        }
    }
}