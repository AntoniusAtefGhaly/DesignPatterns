using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class ObserverType2 : IObserver
    {
        string _name;
        public ObserverType2(string name)
        {
            _name = name;
        }
        public void Update()
        {
            Console.WriteLine("Notfy from subject to :" + _name);

        }
    }
}
