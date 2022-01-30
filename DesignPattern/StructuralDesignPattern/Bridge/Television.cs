using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Television : ElectronicGoods
    {
        public override void MoveToCurrentState()
        {
            Console.Write("\ntelvison is at ");
            state.MoveState();
        }
    }
}
