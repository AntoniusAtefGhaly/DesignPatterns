using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Modified
{
    internal class Invoke
    {
        ICommand CommandToBePerformed;
        public void ExecuteCommand()
        {
            CommandToBePerformed.Do();
        }
        public void UndoCommand()
        {
            CommandToBePerformed.UnDo();
        }
        public void SetCommand(ICommand command)
        {
            CommandToBePerformed = command;
        }
    }
}
