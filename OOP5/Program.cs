using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Employee emp = new Employee();

            p.Display();
            emp.Display(emp.company);

            Console.ReadKey();
        }
    }

    class Person
    {
        public string firstName, lastName;

        public Person()
        {
            firstName = "Steve"; lastName = "Jobs";
        }
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName; this.lastName = lastName;
        }

        public void Display()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
        public void Display(string comp)
        {
            Console.WriteLine(firstName + " " + lastName + ", " + comp);
        }
    }

    class Employee : Person
    {
        public string company;

        public Employee() : base("Bill", "Gates")
        {
            company = "Microsoft";
        }
    }
}
