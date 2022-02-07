using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class ComputerScience : BasicEngineering
    {
        public override void SpecialPaper()
        {
            Console.WriteLine("c# programming");
        }
        public override bool IsAdditionalPapersNeeded()
        {
            return false;
        }
    }
}
