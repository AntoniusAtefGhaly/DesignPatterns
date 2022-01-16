using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1_Proxy
{
    internal interface ISMSService
    {
        void SendSMS(string Sender,string reciever,string SMS);
    }
}
