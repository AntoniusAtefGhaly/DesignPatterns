using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class ScienceIterator : IIterator
    {
        private LinkedList<string> Subjects;
        int postion = 0;

        public ScienceIterator(LinkedList<string> subjects)
        {
            Subjects = subjects;
        }

        public string CurrentItem()
        {
            if(postion < Subjects.Count)
                return Subjects.ElementAt(postion);
            return "";
        }

        public void First()
        {
            postion=0;
        }

        public bool IsDone()
        {
            if (postion < Subjects.Count)
                return false;
            return true;
        }

        public string Next()
        {
            if(postion < Subjects.Count)
                return Subjects.ElementAt(postion++);
            return "";
        }
    }
}
