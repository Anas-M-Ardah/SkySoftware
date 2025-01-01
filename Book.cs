using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Library_Management_System
{
    internal class Book : LibraryItem
    {
        public int YearOfPublication { get; }
        public string Genre { get; }
        private int NumberOfPages { get; }

        public Book(string name, int yearOfPublication, string genre, int numberOfPages)
        {
            this.YearOfPublication = yearOfPublication;
            this.Genre = genre;
            this.NumberOfPages = numberOfPages;
            this.name = name;
        }

        public override string ToString()
        {
            return $"Book: {this.name}" +
                   $", {this.YearOfPublication}" +
                   $", Genre: {this.Genre}" +
                   $", Pages: {this.NumberOfPages}";
        }

        public override void Print()
        {
            Color("Book", this.name);
            Color(this.YearOfPublication.ToString(), ConsoleColor.Green);
            Color("Genre", this.Genre);
            Color("Pages", this.NumberOfPages.ToString(), false);
            Console.WriteLine();
        }

        protected override string getName()
        {
            return name;
        }

        protected override void setName(string name)
        {
            this.name = name;
        }
    }
}
