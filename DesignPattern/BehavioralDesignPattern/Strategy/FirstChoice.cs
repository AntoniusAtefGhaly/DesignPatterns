using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class FirstChoice : IChoice
    {
        public void MyChoice()
        {
            Console.WriteLine("choice 1");   
        }
    }
}
