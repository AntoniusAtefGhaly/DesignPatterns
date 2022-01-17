using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Calculate
    {
        public double CalculatBouns(Employee employee)
        {
            return employee.Salary * 1.5;
        }
    }
}
