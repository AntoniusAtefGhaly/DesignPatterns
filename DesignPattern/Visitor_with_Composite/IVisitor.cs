using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_with_Composite
{
    internal interface IVisitor
    {
        void VisitCompositeElement(CompositeEmployee employee);
        void VisitLeafElement(Employee employee);
    }
}
