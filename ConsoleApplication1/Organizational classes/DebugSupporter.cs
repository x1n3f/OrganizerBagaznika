using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace OrganizerBagaznika
{
    static class DebugSupporter
    {
        private static ConsoleColor fontColor = ConsoleColor.Red;

        [Conditional("DEBUG")]
        public static void printPropertyValue(string name, object property)
        {
            Console.ForegroundColor = fontColor;
            Console.WriteLine("Property: {0} has value: {1}", name, property);
            Console.ResetColor();
        }

        [Conditional("DEBUG")]
        public static void printCustomMessage(string message)
        {
            Console.ForegroundColor = fontColor;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
