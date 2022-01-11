using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDP
{
    public class Counter
    {
        public int Count { get; set; }
        public void addOne()
        {
            Count++;
        }
    }
}
