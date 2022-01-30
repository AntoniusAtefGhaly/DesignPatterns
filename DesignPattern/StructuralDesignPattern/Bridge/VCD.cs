using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class VCD : ElectronicGoods
    {
        public override void MoveToCurrentState()
        {
            Console.Write("\nVCD is at ");
            state.MoveState();
        }
    }
}
