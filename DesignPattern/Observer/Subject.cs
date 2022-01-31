using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Subject : ISubject
    {
        int flag;
        IList<IObserver> observerList;

        public Subject()
        {
            this.observerList = new List<IObserver>();
        }

        public int Flag
        {
            get
            {
                return flag;
            }
            set
            {
                if (value != flag)
                {
                    NotifyRegisteredUsers();
                    flag = value;
                }
            }
        }
        public void NotifyRegisteredUsers()
        {
            foreach(IObserver observer in observerList)
            {
                observer.Update();
            }
        }

        public void Register(IObserver observer)
        {
            observerList.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            observerList.Remove(observer);
        }
    }
}
