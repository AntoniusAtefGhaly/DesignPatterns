using System;

namespace Command_Modified // Note: actual namespace depends on the project name.
{
    internal class Client
    {
        static void Main(string[] args)
        {
            Invoke invoke = new Invoke();
            Console.WriteLine("\n\n \t\treciever1");
            Reciever1 reciever = new Reciever1();
            AddtionalCommand command = new AddtionalCommand(reciever);
            invoke.SetCommand(command);
            Console.WriteLine("");
            invoke.ExecuteCommand();
            Console.WriteLine("");
            invoke.UndoCommand();
            Console.WriteLine("");
            invoke.UndoCommand();

            Console.WriteLine("\n\n\t\treciever2");
            Reciever2 reciever2 = new Reciever2();
            AddtionalCommand command2 = new AddtionalCommand(reciever2);
            invoke.SetCommand(command2);
            Console.WriteLine("");
            invoke.ExecuteCommand();
            invoke.ExecuteCommand();
            Console.WriteLine("");
            invoke.UndoCommand();
            Console.WriteLine("");
            invoke.UndoCommand();
            Console.WriteLine("");
            invoke.UndoCommand();
        }
    }
}