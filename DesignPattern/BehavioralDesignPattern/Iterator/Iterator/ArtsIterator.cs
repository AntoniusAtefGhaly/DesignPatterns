using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class ArtsIterator : IIterator
    {
        private string[] subjects;
        int postion=0;

        public ArtsIterator(string[] subjects)
        {
            this.subjects = subjects;
        }

        public string CurrentItem()
        {
            if(postion<subjects.Length)
            return subjects[postion];
            return "";
        }

        public void First()
        {
            postion=0;
        }

        public bool IsDone()
        {
            if(postion<subjects.Count())
                return false;
            return true;
        }

        public string Next()
        {
            if (postion < subjects.Count())
            {
                return subjects[postion++];
            }
            return "";
        }
    }
}
