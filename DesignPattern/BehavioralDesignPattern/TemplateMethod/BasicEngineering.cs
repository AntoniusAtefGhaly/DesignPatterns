using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal abstract class BasicEngineering
    {
        private  void Math()
        {
            Console.WriteLine("Math");
        }
        public void Papers()
        {
            Math();
            SoftSkills();
            SpecialPaper();
            if (IsAdditionalPapersNeeded())
            {
                AddtionalPaper();
            }
        }
        private void SoftSkills()
        {
            Console.WriteLine("SoftSkills");
        }
        private void AddtionalPaper()
        {
            Console.WriteLine("Addtional Papers");
        }
        public abstract void SpecialPaper();
        public virtual bool IsAdditionalPapersNeeded()
        {
            return true;
        }
    }
}
