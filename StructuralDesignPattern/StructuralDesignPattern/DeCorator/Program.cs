using System;

namespace Decorator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SMSServiceProxy smsProxy = new SMSServiceProxy();
            
            //Console.WriteLine(smsProxy.SendSMS("010045856", "0125456545", "hello"));
            //Console.WriteLine(smsProxy.SendSMS("010045856", "0125456545", "hello"));
            //Console.WriteLine(smsProxy.SendSMS("010045856", "0125456545", "hello"));
            //Console.WriteLine(smsProxy.SendSMS("010045856", "0125456545", "hello"));
            //Console.WriteLine(smsProxy.SendSMS("010045856", "0125456545", "hello"));


            ISMSService smsService = new SMSService();
            EmailDecorator decorator = new EmailDecorator();
            decorator.SetService(smsService);
            Console.WriteLine(decorator.SendSMS("010045856", "0125456545", "hello"));
            Console.WriteLine(decorator.SendSMS("010045856", "0125456545", "hello"));
            Console.WriteLine(decorator.SendSMS("010045856", "0125456545", "hello"));
            Console.WriteLine(decorator.SendSMS("010045856", "0125456545", "hello"));
            Console.WriteLine(decorator.SendSMS("010045856", "0125456545", "hello"));
        }
    }
}