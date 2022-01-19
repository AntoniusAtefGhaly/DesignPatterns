using System;

namespace FactoryDesignPattern 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter bank account");
            string bankAcount = Console.ReadLine();
            IBankFactory bankFactory = new BankFactory();
            IBank bank = bankFactory.Create(bankAcount);
            bank.Withdrow();
        }
    }
}