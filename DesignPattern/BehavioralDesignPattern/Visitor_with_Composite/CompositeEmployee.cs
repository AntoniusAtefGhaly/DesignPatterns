using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_with_Composite
{
    internal class CompositeEmployee:IEmployee
    {
        private string name;
        private string dept;
        private int yearsOfExperience;
        private IList<IEmployee> controls;

        public CompositeEmployee(string name, string dept, int yearsOfExperience)
        {
            this.name = name;
            this.dept = dept;
            controls = new List<IEmployee>();
            this.yearsOfExperience = yearsOfExperience;
        }
        public void Add(IEmployee employee)
        {
            controls.Add(employee);
        }
        public void Remove(IEmployee employee)
        {
            controls.Remove(employee);
        }
        public int Experience { get { return yearsOfExperience; } }
        public string Name { get { return name; } }
        public IList<IEmployee> Controls { get { return controls; } }

        public void PrintStuctures()
        {
            //Console.WriteLine("\t" + this.name + "works in" + this.dept);
            Console.WriteLine("name: " + this.name + " works in : " + this.dept + " experience : " + yearsOfExperience);
            foreach (var employee in controls)
            {
                employee.PrintStuctures();
            }
        }

        public void accept(IVisitor visitor)
        {
            visitor.VisitCompositeElement(this);
        }
    }
}
