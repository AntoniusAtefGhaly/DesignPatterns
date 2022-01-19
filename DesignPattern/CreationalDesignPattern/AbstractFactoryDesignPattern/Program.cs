using System;

namespace AbstractFactoryDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter bank account");
            string bankAcount = Console.ReadLine();
            
            //bank
            IBankFactory bankFactory = new BankFactory();
            IBank bank = bankFactory.CreateBank(bankAcount);
            bank.Withdrow();

            //card
            IPaymentMethod payment = bankFactory.CreatePaymentMethod("222");
            Console.WriteLine(payment.Name);




        }
    }
}