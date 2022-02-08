using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Modified
{
    internal class AddtionalCommand : ICommand
    {
        IReciever reciever;
        public AddtionalCommand(IReciever reciever)
        {
            this.reciever = reciever;
        }
        public void Do()
        {
            reciever.OptionalTaskPreProcessing();
            reciever.Add2WithNumber();
            reciever.OptionalTaskPostProcessing();
        }
        public void UnDo()
        {
            reciever.OptionalTaskPreProcessing();
            reciever.Remove2FromNumber();
            reciever.OptionalTaskPostProcessing();
        }
    }
}