using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    internal class TempEmployee:EmployeePrototype
    {
        public override EmployeePrototype ShalowCopy()
        {
            return (TempEmployee)this.MemberwiseClone();
        }

        public override EmployeePrototype DeepCopy()
        {
            var emp = (TempEmployee)MemberwiseClone();
            emp.address = new Address
            {
                building = this.address.building,
                City = this.address.City,
                street = this.address.street
            };
            emp.Name = this.Name;
            return emp;
        }
    }
}
