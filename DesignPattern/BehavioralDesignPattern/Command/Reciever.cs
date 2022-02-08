using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Reciever
    {
        public void OptionalTaskToRedo()
         {
            Console.WriteLine("Executing-Optional Tasks prior to execute redo command");
         }
        public void OptionalTaskToUndo()
         {
            Console.WriteLine("Executing-Optional Tasks prior to execute   undo command");
         }
        public void PerformRedo()
        {
            Console.WriteLine("Executing-MyRedoCommand");
        }
        public void PerformUndo()
        {
            Console.WriteLine("Executing-MyUndoCommand");
        }
    }
}
