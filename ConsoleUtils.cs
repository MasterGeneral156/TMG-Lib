using System;
using System.Collections.Generic;
using System.Text;

namespace TMGLib
{
    public class ConsoleUtils
    {
        //Error text in console! Changes text to red.
        public static void consoleError(string appID, string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[" + appID + "] " + error);
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Info text in console! Changes text to blue.
        public static void consoleInfo(string appID, string info)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[" + appID + "] " + info);
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Success text in console! Changes text to green.
        public static void consoleSuccess(string appID, string success)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[" + appID + "] " + success);
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Warning text in console! Changes text to yellow.
        public static void consoleWarning(string appID, string warning)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[" + appID + "] " + warning);
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Default text in console. Color is white.
        public static void consoleOutput(string appID, string output)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[" + appID + "] " + output);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
