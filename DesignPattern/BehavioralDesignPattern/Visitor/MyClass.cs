using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class MyClass : IOriginalInterface
    {
        int myInt=5;
        public int MyInt
        {
            set { myInt = value; }
            get { return myInt; }
        }
        public void Accept(IVisitor visitor)
        {
            Console.WriteLine("Initial value of the integer:{0}", myInt);
            visitor.Visit(this);
            Console.WriteLine("\nValue of the integer now:{0}", myInt);
        }
    }
}
