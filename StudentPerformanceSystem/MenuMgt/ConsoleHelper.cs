using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceSystem.MenuMgt
{
    public class ConsoleHelper
    {

        public static void WriteText(int width,string text)
        {
            int val = width - text.Length;
            string leftString = new string(' ', val / 2);
            string rightString = new string(' ', val / 2);
            Console.Write(leftString + text + rightString);
        }
        public static void WriteHeader(int width,string text)
        {   
            Console.WriteLine(new String('-',width));
            int val = width - text.Length;
            string leftString = '|'+new string(' ', (val / 2)-1);
            string rightString = new string(' ', (val / 2)-1)+"|";
            Console.WriteLine(leftString + text + rightString);


            Console.WriteLine(new String('-', width));
        }
        public static void DrawLine(int width)
        {
            string line=new string('_', width);
            Console.WriteLine(line);
        }
        public static void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
