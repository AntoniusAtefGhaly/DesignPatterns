using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_with_Composite
{
    internal class Visitor : IVisitor
    {
        public void VisitCompositeElement(CompositeEmployee employee)
        {
            if (employee.Experience > 20)
            {
                Console.WriteLine(employee.Name + "is elegible for promote");
            }
            else 
            {
                Console.WriteLine(employee.Name + "is not elegible for promote");
            }
                foreach (var item in employee.Controls)
            {
                item.accept(this);
            }
        }

        public void VisitLeafElement(Employee employee)
        {
            if (employee.Experience > 10)
            {
                Console.WriteLine(employee.Name + "is elegible for promote");
                
            }
            else
            {
                Console.WriteLine(employee.Name + "is not elegible for promote");
            }
        }
    }
}
