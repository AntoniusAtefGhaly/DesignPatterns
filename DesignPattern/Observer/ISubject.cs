using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal interface ISubject
    {
        void NotifyRegisteredUsers();
        void Register(IObserver observer);
        void Unregister(IObserver observer);
    }
}
