using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    public abstract class EmployeePrototype
    {
        public int Id { get; set; }
        public string Name { get; set; }  
        public Address address { get; set; }
        public abstract EmployeePrototype ShalowCopy();
        public abstract EmployeePrototype DeepCopy();
        public override string ToString()
        {
            return   
$@"Id={Id}
Name : {Name}  
Address : {address.City},{address.street},{address.building}";
        }
    }
}
