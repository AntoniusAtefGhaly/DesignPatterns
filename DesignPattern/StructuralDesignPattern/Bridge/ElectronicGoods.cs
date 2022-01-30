using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract internal class ElectronicGoods
    {
        protected IState state;
        public IState State
        {
            get
            {
                return state;
            }
            set 
            { 
                state = value;
            }
        }
        abstract public void MoveToCurrentState();
    }
}
