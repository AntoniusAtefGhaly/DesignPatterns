using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Context
    {
        private IChoice choice;
        public void SetChoice(IChoice choice)
        {
            this.choice = choice;
        }
        public void ShowChoice()
        {
            choice.MyChoice();
        }
    }
}
