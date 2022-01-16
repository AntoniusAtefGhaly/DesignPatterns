using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    internal class MasterCard : IPaymentMethod
    {
        public string Name { get; set; } = "Master card";
        public string provider { get; set; } = "MASTERCARD";

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
