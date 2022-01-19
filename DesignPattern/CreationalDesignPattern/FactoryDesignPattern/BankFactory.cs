using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class BankFactory : IBankFactory
    {
        public IBank Create(string accountNum)
        {
            
            switch (accountNum.Substring(0,3))
            {
                case "111":
                    return new BankA();
                case "222":
                    return new BankB();
            }
            return null;
        }
    }
}
