using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    internal class BankA : IBank
    {
        public void Withdrow()
        {
            Console.WriteLine("process handle by bank A");
        }
    }
}
