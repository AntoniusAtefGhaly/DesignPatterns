using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTone_LazyInitialize
{
    public class Counter
    {
        public int Count { get; set; }
        private static Counter instance ;
        private Counter()
        {

        }
        public static Counter GetInstance()
        {
            if (instance == null)
            {
                instance = new Counter();
            }
            return instance;
        }
        public void AddOne()
        {
            Count++;
        }
    }
}
