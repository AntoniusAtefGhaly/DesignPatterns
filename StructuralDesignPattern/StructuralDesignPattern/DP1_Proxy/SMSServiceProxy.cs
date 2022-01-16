using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1_Proxy
{
    internal class SMSServiceProxy
    {
        private ISMSService _service;
        IDictionary<string, int> _UsersBalance = new Dictionary<string, int>();
        public void SendSMS(string Sender, string reciever, string SMS)
        {
            if (_service == null)
            {
                _service = new SMSService();
            }
            if (!_UsersBalance.ContainsKey(Sender))
            {
                _UsersBalance.Add(Sender, 2);
                _service.SendSMS(Sender, reciever, SMS);
            }
            else
            {
                var customer = _UsersBalance.Where(c => c.Key == Sender).FirstOrDefault();
                if ( customer.Value>0)
                {  
                _service.SendSMS(Sender, reciever, SMS);
                    _UsersBalance[Sender] = customer.Value - 1;
                }
                else
                {
                    Console.WriteLine("your balance is runout");
                }
            }
        }
    }
}
