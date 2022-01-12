using System;

namespace PrototypeDesignPattern // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region shallow copy
            EmployeePrototype tempEmployee1 = new TempEmployee();
            tempEmployee1.Name = "antonius atef";
            tempEmployee1.Id = 1;
            tempEmployee1.address = new Address() { City="cairo",street="zahraa",building="1"};

            //create copy of emp1
            EmployeePrototype tempEmployee2 = tempEmployee1.ShalowCopy();
           
            Console.WriteLine("-----------original employee 1  -----------------");
            Console.WriteLine(tempEmployee1.ToString());
            Console.WriteLine("----------- employee 2  -------------------------");
            Console.WriteLine(tempEmployee2.ToString());

            tempEmployee2.Name = "emp2";
            tempEmployee2.Id = 2;
            tempEmployee2.address.City = "city2";
            tempEmployee2.address.street = "street 2";
            tempEmployee2.address.building = "building 2";

            Console.WriteLine("-----------original employee 1 after change 2  -----------------");
            Console.WriteLine(tempEmployee1.ToString());
            Console.WriteLine("----------- employee 2  after change   -------------------------");
            Console.WriteLine(tempEmployee2.ToString());
            #endregion
            #region deep copy
            EmployeePrototype tempEmployee3 = new TempEmployee();
            tempEmployee1.Name = "antonius atef";
            tempEmployee1.Id = 1;
            tempEmployee1.address = new Address() { City = "cairo", street = "zahraa", building = "1" };

            //create copy of emp1
            EmployeePrototype tempEmployee4 = tempEmployee1.DeepCopy();

            Console.WriteLine("-----------original employee 1  -----------------");
            Console.WriteLine(tempEmployee3.ToString());
            Console.WriteLine("----------- employee 2  -------------------------");
            Console.WriteLine(tempEmployee4.ToString());

            tempEmployee4.Name = "emp2";
            tempEmployee4.Id = 2;
            tempEmployee4.address.City = "city2";
            tempEmployee4.address.street = "street 2";
            tempEmployee4.address.building = "building 2";

            Console.WriteLine("-----------original employee 3 after change 2  -----------------");
            Console.WriteLine(tempEmployee3.ToString());
            Console.WriteLine("----------- employee 4  after change   -------------------------");
            Console.WriteLine(tempEmployee4.ToString());
            #endregion
        }
    }
}