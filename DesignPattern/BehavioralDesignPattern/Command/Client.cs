using System;

namespace Command // Note: actual namespace depends on the project name.
{
    internal class Client
    {
        static void Main(string[] args)
        {
            Invoke invoke = new Invoke();
            Reciever reciever = new Reciever();
            MyUndoCommand undoCommand = new MyUndoCommand(reciever);

            invoke.SetCommand(undoCommand);
            invoke.ExecuteCommand();

            MyRedoCommand myRedoCommand = new MyRedoCommand(reciever);
            invoke.SetCommand(myRedoCommand);
            invoke.ExecuteCommand();
        }
    }
}