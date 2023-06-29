using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace P07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;

            List<int> originaList = new List<int>();
            bool isListChanged = false;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(' ');
                string instruction = command[0];
                if (instruction == "Add" || instruction == "Remove" || instruction == "Insert" || instruction == "RemoveAt")
                {
                    isListChanged = true; 
                }
                if (instruction == "Add")
                {
                    int number = int.Parse(command[1]);
                    numbers.Add(number);

                }
                else if (instruction == "Remove")
                {
                    int number = int.Parse(command[1]);
                    numbers.Remove(number);
                }
                else if (instruction == "RemoveAt")
                {
                    int index = int.Parse(command[1]);
                    numbers.RemoveAt(index);
                }
                else if (instruction=="Insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    numbers.Insert(index, number);
                }
                else if (instruction == "Contains") // with method
                {
                    int number = int.Parse(command[1]);
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (instruction == "PrintEven") // with method
                {
                    foreach (int number in numbers)
                    {
                        if (number % 2 == 0)
                        {
                            Console.Write(number+" ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (instruction == "PrintOdd") // with method
                {
                    foreach (int number in numbers)
                    {
                        if (number % 2 != 0)
                        {
                            Console.Write(number + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (instruction == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else
                {
                    string condition = command[1];
                    int conditionNum = int.Parse(command[2]);
                    string resultingList = string.Empty;
                    switch (condition)
                    {
                        case "<":
                            resultingList = string.Join(" ",SmallerNums(numbers, conditionNum));
                            break;
                        case ">":
                            resultingList = string.Join(" ", BiggerNums(numbers, conditionNum)); 
                            break;
                        case "<=":
                            resultingList = string.Join(" ", SmallerNums(numbers, conditionNum+1));
                            break;
                        case ">=":
                            resultingList = string.Join(" ", BiggerNums(numbers, conditionNum-1));
                            break;
                    }
                            Console.WriteLine(resultingList);
                }
            }
            if (isListChanged)
            {
            Console.WriteLine(string.Join(" ", numbers));
            }
        }
        static List<int> SmallerNums(List<int> numbers, int conditionNum)
        {
            List<int> filteredNums = new List<int>();
            foreach (int number in numbers)
                {
                    if (number < conditionNum)
                    {
                        filteredNums.Add(number);
                    }
                }
            return filteredNums;
        }
         static List<int> BiggerNums(List<int> numbers, int conditionNum)
        {
            List<int> filteredNums = new List<int>();
            foreach (int number in numbers)
            {
                if (number > conditionNum)
                {
                    filteredNums.Add(number);
                }
            }

            return filteredNums;
        }
    }
}