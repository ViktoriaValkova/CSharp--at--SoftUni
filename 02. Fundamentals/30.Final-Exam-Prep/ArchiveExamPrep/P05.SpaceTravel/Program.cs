using System;

namespace P05.SpaceTravel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string planetName = Console.ReadLine();
                string codedMsg = Console.ReadLine();
                string decodedMsg = string.Empty;
                for (int i = 0; i < codedMsg.Length-1; i+=2)
                {
                    int firstNum = int.Parse(codedMsg[i].ToString());
                    int secondNum = int.Parse(codedMsg[i+1].ToString());
                    int currentCharValue = int.Parse(firstNum.ToString()+secondNum.ToString());
                    
                    decodedMsg += (char)currentCharValue;
                }

                Console.WriteLine(decodedMsg);
                if (decodedMsg == "GO HOME")
                {
                    Console.WriteLine("Going home.");
                    break;
                }
            }

        }
    }
}