using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class CompositeEmployee:IEmployee
    {
        private string name;
        private string dept;
        private IList<IEmployee> controls; 

        public CompositeEmployee(string name, string dept)
        {
            this.name = name;
            this.dept = dept;
            controls = new List<IEmployee>();
        }
        public void Add(IEmployee employee)
        {
            controls.Add(employee);
        }
        public void Remove(IEmployee employee)
        {
            controls.Remove(employee);
        }
  

        public void PrintStuctures()
        {
            //Console.WriteLine("\t" + this.name + "works in" + this.dept);
            Console.WriteLine("name: " + this.name + "works in : " + this.dept);
            foreach (var employee in controls)
            {
                employee.PrintStuctures();
            }
        }
    }
}
