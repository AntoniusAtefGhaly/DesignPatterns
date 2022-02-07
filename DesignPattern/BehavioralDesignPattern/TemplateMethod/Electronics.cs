using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class Electronics : BasicEngineering
    {
        public override void SpecialPaper()
        {
            Console.WriteLine("Electronics and digital");
        }
    }
}
