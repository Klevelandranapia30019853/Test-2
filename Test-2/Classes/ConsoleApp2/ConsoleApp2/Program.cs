using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Salary s1 = new Salary();
            Person p1 = new Person();

            Console.Write("Please enter the person's first name: ");
            p1.Fname = Console.ReadLine();
            Console.Write("Please enter the person's last name: ");
            p1.Lname = Console.ReadLine();

            Console.WriteLine("This is the amount of salary you are getting per year");
            Console.WriteLine("80,000");
            Console.ReadLine();

            Console.WriteLine("This is the amount you get paid per Week");
            Console.WriteLine("$1536.46");
            Console.ReadLine();
        }
    }

    internal class Person
    {
        internal string Fname;
        internal string Lname;
    }

    internal class Salary
    {
        internal string Fname;
        internal string Lname;
        internal int Wages;

    }
}
