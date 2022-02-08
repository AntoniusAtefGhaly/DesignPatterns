using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal interface IIterator
    {
        string CurrentItem();
        void First();
        bool IsDone();
        string Next();
    }
}
