using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Library_Management_System
{
    internal abstract class LibraryItem
    {
        protected string name;

        protected abstract string getName();
        protected abstract void setName(string name);
        public abstract void Print();

        protected void Color(string key, string value, bool isNotEnd = true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{key}: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(isNotEnd ? $"{value}, " : $"{value}");
            Console.ResetColor();
        }

        protected void Color(string value, ConsoleColor color, bool isNotEnd = true)
        {
            Console.ForegroundColor = color;
            Console.Write($"{value}");
            Console.ForegroundColor = color;
            Console.Write(isNotEnd ? ", ": "");
            Console.ResetColor();
        }
    }
}
