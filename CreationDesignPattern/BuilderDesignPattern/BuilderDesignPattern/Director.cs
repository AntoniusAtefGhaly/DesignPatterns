using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    internal class Director
    {
        IBuilder builder;
        public void Construct(IBuilder builder)
        {
            this.builder = builder;
            builder.StartOperation();
            builder.BuildBody();
            builder.InsertWheels();
            builder.AddHeadLights();
            builder.EndOperation();
        }
    }
}
