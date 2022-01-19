using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    internal class VisaCard : IPaymentMethod
    {
        public string Name { get; set; }= "visa card";

        public string provider { get; set; } = "VISA";

        public string GetName()
        {
            return Name;
        }

        public string GetProvider()
        {
            return provider;
        }
    }
}
