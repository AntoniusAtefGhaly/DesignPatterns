using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class EmailDecorator : AbstractDecorator
    {
      public string SMSSendNotification (string Reciever, string SMS)
        {
            return $" sms {SMS},send to {Reciever} at {DateTime.Now.ToLongDateString()}";
        }
         public string SendSMS(string Sender, string reciever, string SMS)
        {
            return base.SendSMS(Sender,reciever,SMS)+
                "\n  "+SMSSendNotification(reciever,SMS);
        }
    }
}
