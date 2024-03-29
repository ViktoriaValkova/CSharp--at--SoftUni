﻿using System.Threading.Channels;

namespace P04.MorseCodeTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            foreach (string str in input)
            {
                switch (str)
                {
                    case "|": Console.Write(" ");
                        break;
                    case ".-": Console.Write("A");
                        break;
                    case "-...": Console.Write("B");
                        break;
                    case "-.-.": Console.Write("C");
                        break;
                    case "-..": Console.Write("D");
                        break;
                    case ".": Console.Write("E");
                        break;
                    case "..-.": Console.Write("F");
                        break;
                    case "--.": Console.Write("G");
                        break;
                    case "....": Console.Write("H");
                        break;
                    case "..": Console.Write("I");
                        break;
                    case ".---": Console.Write("J");
                        break;
                    case "-.-": Console.Write("K");
                        break;
                    case ".-..": Console.Write("L");
                        break;
                    case "--": Console.Write("M");
                        break;
                    case "-.": Console.Write("N");
                        break;
                    case "---": Console.Write("O");
                        break;
                    case ".--.": Console.Write("P");
                        break;
                    case "--.-": Console.Write("Q");
                        break;
                    case ".-.": Console.Write("R");
                        break;
                    case "...": Console.Write("S");
                        break;
                    case "-": Console.Write("T");
                        break;
                    case "..-": Console.Write("U");
                        break;
                    case "...-": Console.Write("V");
                        break;
                    case ".--": Console.Write("W");
                        break;
                    case "-..-": Console.Write("X");
                        break;
                    case "-.--": Console.Write("Y");
                        break;
                    case "--..": Console.Write("Z");
                        break;
                    
                }
            }

        }
    }
}