using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Library_Management_System
{
    internal class Magazine : LibraryItem
    {
        public string Publisher { get; }
        public int IssueNumber { get; }
        public int IssueYear { get; }

        public Magazine(string name, string publisher ,int  issueNumber, int issueYear)
        {
            this.name = name;
            this.Publisher = publisher;
            this.IssueNumber = issueNumber;
            this.IssueYear = issueYear;
        }

        public override string ToString()
        {
            return $"Magazine: {name}, Publisher: {Publisher}, Issue: {IssueNumber}/{IssueYear}";
        }

        public override void Print()
        {
            Color("Magazine", this.name);
            Color("Publisher", this.Publisher);
            Color("Issue", this.IssueNumber.ToString());
            Color(this.IssueYear.ToString(), ConsoleColor.Red, false);
            Console.WriteLine();
        }

        protected override string getName()
        {
            throw new NotImplementedException();
        }

        protected override void setName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
