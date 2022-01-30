using System;

namespace Bridge // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TV");
            ElectronicGoods Device = new Television();
            IState CurrentState = new OnState();
            Device.State = CurrentState;
            Device.MoveToCurrentState();
            CurrentState = new OffState();
            Device.State = CurrentState;
            Device.MoveToCurrentState();

            Console.WriteLine("\n\n\nVCD");
            Device = new VCD();
            CurrentState = new OnState();
            Device.State = CurrentState;
            Device.MoveToCurrentState();
            CurrentState = new OffState();
            Device.State = CurrentState;
            Device.MoveToCurrentState();
        }
    }
}