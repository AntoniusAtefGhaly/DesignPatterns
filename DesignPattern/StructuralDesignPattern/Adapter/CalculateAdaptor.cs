using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class CalculateAdaptor:Calculate
    {
        private Employee _emp;
        
        public double CalculatBouns( MachinOperator machinOperator)
        {
            _emp = new Employee();
            _emp.Salary = machinOperator.Salary;
            return base.CalculatBouns(_emp);
        }
    }
}
