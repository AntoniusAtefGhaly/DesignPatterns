using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    internal class MotorCycle : IBuilder
    {
        private Product product;
        private string brand;

        public MotorCycle(string brand)
        {
            product = new Product();
            this.brand = brand;
        }

        public void AddHeadLights()
        {
            product.Add($"MotorCycle model name :{brand}");
        }

        public void BuildBody()
        {
            product.Add($"body is added");
        }

        public void EndOperation()
        {
            product.Add($"MotorCycle is finished");
        }

        public Product GetVicle()
        {
            return product;
        }

        public void InsertWheels()
        {
            product.Add($"2 wheels are added");
        }

        public void StartOperation()
        {
            product.Add($"operation is started");
        }
    }
}
