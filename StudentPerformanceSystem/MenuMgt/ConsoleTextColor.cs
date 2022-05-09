using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceSystem.MenuMgt
{
    public static class ConsoleTextColor
    {
        public static void SetError()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
        }
        public static void SetWarning()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
        }

        public static void Reset()
        {
            Console.ResetColor();
        }

        public static void SetHighlight()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Cyan;
        }


        public static void SetColor()
        {
            Console.ForegroundColor = ConsoleColor.Black;

        }


    }
}
