using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_with_Composite
{
    internal interface IEmployee
    {
        void PrintStuctures();
        void accept(IVisitor visitor);
    }
}
