using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class MyRedoCommand : ICommand
    {
        Reciever reciever;
        public MyRedoCommand(Reciever reciever)
        {
            this.reciever = reciever;
        }
        public void Do()
        {
            reciever.OptionalTaskToRedo();
            reciever.PerformRedo();
        }
    }
}