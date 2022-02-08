using Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
   
    internal class MyUndoCommand : ICommand
    {
        private Reciever reciever;

        public MyUndoCommand(Reciever reciever)
        {
            this.reciever = reciever;
        }
        public void Do()
        {
            reciever.OptionalTaskToUndo();
            reciever.PerformUndo();
        }
    }
}
