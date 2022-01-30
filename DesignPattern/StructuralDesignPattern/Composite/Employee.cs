using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Employee : IEmployee
    {
        private string dept;
        private string name;

        public Employee(string name, string dept)
        {
            this.dept = dept;
            this.name = name;
        }
        public void PrintStuctures()
        {
            Console.WriteLine("name: " + this.name + "works in : " + this.dept);
        }
    }
}
