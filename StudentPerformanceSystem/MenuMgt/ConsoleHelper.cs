using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceSystem.MenuMgt
{
    public class ConsoleHelper
    {

        public static void ShowError(string message)
        {
            ConsoleTextColor.SetError();
            Console.WriteLine(message);
            ConsoleTextColor.Reset();
        }
        public static void ShowWarning(string message)
        {
            ConsoleTextColor.SetWarning();
            Console.WriteLine(message);
            Console.ResetColor();
        }


        public static void WriteText(int width,string text)
        {
            Console.BackgroundColor = ConsoleColor. Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            int val = width - text.Length;
            
            int lv = val / 2;
            string leftString = new string(' ', val%2==0 ? lv:lv+1);
            string rightString = new string(' ',lv);
                Console.Write(leftString + text + rightString);
            Console.ResetColor();
        }


        public static void WriteHeader(int width,string text)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(new String('-',width));
            int val = width - text.Length;
            string leftString = '|'+new string(' ', (val / 2)-1);
            string rightString = new string(' ', (val / 2))+"|";
            Console.WriteLine(leftString + text + rightString);


            Console.WriteLine(new String('-', width));
            Console.ResetColor();
        }
        public static void DrawLine(int width)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            string line=new string('_', width);
            Console.WriteLine(line);
            Console.ResetColor();
        }
        public static void WriteLine()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.ResetColor ();

        }
        public static void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
