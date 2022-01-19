using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    internal interface IBankFactory
    {
        IBank CreateBank(string account);
        IPaymentMethod CreatePaymentMethod(string CardNum);
    }
}
