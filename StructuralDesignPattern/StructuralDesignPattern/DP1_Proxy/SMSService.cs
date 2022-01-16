using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1_Proxy
{
    internal class SMSService : ISMSService
    {
        public void SendSMS(string Sender, string reciever, string SMS)
        {
            Console.WriteLine("*********************sms***********************");
            Console.WriteLine($"{SMS}\nsender: {Sender} TO {reciever}\nSUCCUFULLY SENT");
            Console.WriteLine("************************************************");
        }
    }
}
