using System;

namespace DP1_Proxy // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region before proxy
            //SMSService smsService = new SMSService();
            //smsService.SendSMS("010045856","0125456545","hello");
            #endregion
            SMSServiceProxy smsProxy = new SMSServiceProxy();
            smsProxy.SendSMS("010045856", "0125456545", "hello");
            smsProxy.SendSMS("010045856", "0125456545", "hello");
            smsProxy.SendSMS("010045856", "0125456545", "hello");
            smsProxy.SendSMS("010045856", "0125456545", "hello");
            smsProxy.SendSMS("010045856", "0125456545", "hello");
        }
    }
}