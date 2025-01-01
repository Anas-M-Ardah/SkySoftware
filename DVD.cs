using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Library_Management_System
{
    internal class DVD : LibraryItem
    {
        public string Director { get; }
        public int Duration { get; }

        public DVD(string name, string director, int duration)
        {
            this.name = name;
            this.Director = director;
            this.Duration = duration;
        }

        public override string ToString()
        {
            return $"DVD: {name}, Director: {Director}, Duration: {Duration} minutes";
        }

        public override void Print()
        {
            Color("DVD", this.name);
            Color("Director", this.Director);
            Color("Duration", this.Duration.ToString(), false);
            Color(" minutes", ConsoleColor.Green, false);
            Console.WriteLine();
        }

        protected override string getName()
        {
            return this.name;
        }

        protected override void setName(string name)
        {
            this.name = name;
        }
    }
}
