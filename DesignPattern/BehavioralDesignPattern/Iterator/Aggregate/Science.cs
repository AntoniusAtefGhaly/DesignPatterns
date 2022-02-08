using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Iterator
{
    internal class Science : ISubjects
    {
        private LinkedList<string> subjects;
        public Science()
        {
            subjects = new LinkedList<string>();
            subjects.AddFirst("Maths");
            subjects.AddFirst("Comp. Sc.");
            subjects.AddFirst("Physics");
        }
    
        public IIterator CreatIterator()
        {
            return new ScienceIterator(subjects);
        }
    }
}