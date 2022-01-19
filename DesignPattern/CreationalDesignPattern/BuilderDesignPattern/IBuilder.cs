using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    internal interface IBuilder
    {
        void StartOperation();
        void BuildBody();
        void InsertWheels();
        void AddHeadLights();
        void EndOperation();
        Product GetVicle();
    }
}
