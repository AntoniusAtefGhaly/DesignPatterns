using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public interface ISMSService
    {
        string SendSMS(string Sender,string reciever,string SMS);
    }
}
