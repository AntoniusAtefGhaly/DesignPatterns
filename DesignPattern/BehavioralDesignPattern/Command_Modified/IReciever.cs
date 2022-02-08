using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Modified
{
    internal interface IReciever
    {
       void Add2WithNumber();
       void Remove2FromNumber();
       void OptionalTaskPreProcessing();
       void OptionalTaskPostProcessing();
    }
}
