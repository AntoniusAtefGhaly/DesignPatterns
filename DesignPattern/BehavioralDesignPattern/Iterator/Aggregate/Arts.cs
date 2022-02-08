using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Arts : ISubjects
    {
        private string[] subjects;

        public Arts()
        {
            subjects = new string[5];
            subjects[0] = "art 1";
            subjects[1] = "art 2";  
            subjects[2] = "art 3";
            subjects[3] = "art 4";
            subjects[4] = "art 5";
        }

        public IIterator CreatIterator()
        {
            return new ArtsIterator(subjects);
        }
    }
}
