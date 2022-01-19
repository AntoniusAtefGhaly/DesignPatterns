using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    internal interface IPaymentMethod
    {
        public string Name { get; }
        public string provider { get; }
        string GetName ();
        string GetProvider ();
    }
}
