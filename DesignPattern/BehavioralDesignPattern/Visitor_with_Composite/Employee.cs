using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_with_Composite
{
    internal class Employee : IEmployee
    {
        private string dept;
        private string name;
        private int yearsOfExperience;

        public Employee(string name, string dept, int yearsOfExperience)
        {
            this.dept = dept;
            this.name = name;
            this.yearsOfExperience = yearsOfExperience;
        }
        public int Experience { get { return yearsOfExperience; } }
        public string Name { get { return name; } }
        public void accept(IVisitor visitor)
        {
            visitor.VisitLeafElement(this);
        }

        public void PrintStuctures()
        {
            Console.WriteLine("name: " + this.name + " works in : " + this.dept + " experience : "+yearsOfExperience);
        }
    }
}
