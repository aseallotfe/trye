using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Employee
    {
        private string name;
        private double salary;
        private string address;
        public Employee()
        {
            Console.WriteLine("Welcome to our company");
        }
        public Employee(string name,double salary,string address):this()
        {
            this.name = name;
            Console.WriteLine(name);
            this.salary = salary;
            Console.WriteLine(salary);
            this.address = address;
            Console.WriteLine(address);
        }
    }
}
