using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CreatureWorld
{
    static class Library
    {
        //declare delegate
        public delegate void PrintDel(string message);

        //points delegate to Print method
        public static PrintDel Print = PrintConsole;

        //points delegate to PrintPlatform method
        public static PrintDel printPlatform = PrintPlatform;

        public static void PrintConsole(string s)
        {
            WriteLine(s);
        }

        public static void PrintPlatform(string s)
        {
            //WPF statements
            throw new NotImplementedException();
        }


        public static void Wait()
        {
            Print("\nPress any key to continue...");
            ReadKey();
        }

        public static string GetInput()
        {
            //string input = ReadLine();
            //return input;
            return ReadLine();
        }

        public static ConsoleColor ChangeForeground(string s)
        {
            switch(s)
            {
                case "red":
                    return ForegroundColor = ConsoleColor.Red;
                    break;
                case "blue":
                    return ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case "green":
                    return ForegroundColor = ConsoleColor.Green;
                    break;
                default:
                    return ForegroundColor = ConsoleColor.White;
                    break;
            }
        }

        public static void ResetConsoleColor()
        {
            ResetColor();
        }

        
    }

}
