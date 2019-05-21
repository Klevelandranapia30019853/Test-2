using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();

            Console.Write("Please enter the person's first name: ");
            p1.Fname = Console.ReadLine();
            Console.Write("Please enter the person's last name: ");
            p1.Lname = Console.ReadLine();
            Console.Write("Please enter the person's age: ");
            p1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nThank you, Here is the information you entered .....");
            Console.ReadLine();
            Console.WriteLine("Name: {0} {1}\nAge: {2}", p1.Fname, p1.Lname, p1.Age);
            Console.ReadLine();
        }
    }

    internal class Person
    {
        internal string Fname;
        internal string Lname;
        internal int Age;
    }
}
