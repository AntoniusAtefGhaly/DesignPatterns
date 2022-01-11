using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementDesignPattern
{
    public class Counter
    {
        public int Count { get; set; }
        private static Counter instance = new Counter();
        private Counter()
        {

        }
        public static Counter GetInstance()
        {
            return instance;
        }
        public void AddOne()
        {
            Count++;
        }
    }
}
