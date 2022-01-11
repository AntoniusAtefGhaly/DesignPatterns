using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadProblem
{
    public class Counter
    {
        public int Count { get; set; }
        public Guid sig { get; set; }
        private static Counter instance ;
        private static object obj=new object();
        private Counter()
        {
            sig=Guid.NewGuid();
        }
        public static Counter GetInstance()
        {
            if (instance == null)
            {
                lock (obj)
                {
                    if (instance == null)
                    {
                        instance = new Counter();
                    }
                }
            }
            return instance;
        }
        public void AddOne()
        {
            lock (obj)
            {
                Count++;
            //    Console.WriteLine(Count.ToString());
            }
        }
    }
}
