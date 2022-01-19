using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class SMSService : ISMSService
    {
        public string SendSMS(string Sender, string reciever, string SMS)
        {
            return 
@$"*********************sms***********************
{SMS}\nsender: {Sender} TO {reciever}\nSUCCUFULLY SENT +
************************************************";
        }
    }
}
