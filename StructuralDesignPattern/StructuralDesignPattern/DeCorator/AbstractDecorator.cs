using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class AbstractDecorator : ISMSService
    {
        protected ISMSService _notifigationService;
        public void SetService(ISMSService service)
        {
            _notifigationService = service;
        }

        public string SendSMS(string Sender, string reciever, string SMS)
        {
            if (_notifigationService != null)
            {
                return _notifigationService.SendSMS(Sender, reciever, SMS);
            }
            else
            {
                return "notifigation Service not initialize";
            }
        }
    }
}
