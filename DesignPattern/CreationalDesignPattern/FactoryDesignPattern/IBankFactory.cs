using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal interface IBankFactory
    {
        IBank Create(string name);
    }
}
