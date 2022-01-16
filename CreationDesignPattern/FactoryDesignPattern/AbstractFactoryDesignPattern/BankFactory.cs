using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    internal class BankFactory : IBankFactory
    {

        public IBank CreateBank(string account)
        {
            switch (account.Substring(0, 3))
            {
                case "111":
                    return new BankA();
                case "222":
                    return new BankB();
            }
            return null;

        }

        public IPaymentMethod CreatePaymentMethod(string CardNum)
        {
            switch (CardNum.Substring(0, 3))
            {
                case "111":
                    return new VisaCard();
                case "222":
                    return new MasterCard();
            }
            return null;
        }
    }
}
