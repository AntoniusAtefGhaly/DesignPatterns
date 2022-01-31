using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class Visitor : IVisitor
    {
        public void Visit(MyClass myClass)
        {
            Console.WriteLine("Visitor is trying to change the integervalue.");
            myClass.MyInt = 9;
            Console.WriteLine("Exiting from Visitor.");
        }
    }
}
