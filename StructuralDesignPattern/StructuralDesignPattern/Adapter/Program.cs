using System;

namespace Adapter // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Name = "EmpName",
                Salary = 1000,
                Id = 1
            };
 
            Calculate calculate = new Calculate();
            Console.WriteLine(employee.Name);
            Console.WriteLine(calculate.CalculatBouns(employee).ToString());

            ///////////////////////////////////////////////////////////////////
            MachinOperator machinOperator = new MachinOperator()
            {
                Salary = 1500,
                Name = "oper",
                Id = 2
            };
            CalculateAdaptor adaptor = new CalculateAdaptor();
            Console.WriteLine(machinOperator.Name);
            Console.WriteLine(adaptor.CalculatBouns(machinOperator).ToString());
        }
    }
}