using System;

namespace Composite // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PRINCIPAL head Org Manger
            CompositeEmployee OrgManger = 
                new CompositeEmployee("mr ahmed(principal) ","Principal");
            //dep 1 : math 2 teacher
            CompositeEmployee HOD1_math = new CompositeEmployee("mr( HOD-math) ", "math");

            //dep 2 : comp sc
            CompositeEmployee HOD2_CompSc = new CompositeEmployee("mr (HOD-copm.sc )", "copm.sc");

            IEmployee teacher1_Math = new Employee("mr (dr1 math)","math");
            IEmployee teacher2_Math = new Employee("mr (dr2 math)","math");

            IEmployee teacher1_CompSc = new Employee("mr (dr1 CompSc)", "CompSc");
            IEmployee teacher2_CompSc = new Employee("mr (dr2 CompSc)", "CompSc");
            IEmployee teacher3_CompSc = new Employee("mr (dr3 CompSc)", "CompSc");


            //compose math dep
            HOD1_math.Add(teacher1_Math);
            HOD1_math.Add(teacher2_Math);

            //compose COMP.SC dep
            HOD2_CompSc.Add(teacher1_CompSc);
            HOD2_CompSc.Add(teacher2_CompSc);
            HOD2_CompSc.Add(teacher3_CompSc);

            //compose orgnization 
            OrgManger.Add(HOD1_math);
            OrgManger.Add(HOD2_CompSc);
            Console.WriteLine("stucture of collage");
             OrgManger.PrintStuctures();
            Console.WriteLine("-------------------------------");

            Console.WriteLine("stucture of comSc dep");
            HOD2_CompSc.PrintStuctures();
            Console.WriteLine("-------------------------------");

            Console.WriteLine("stucture of math");
            HOD1_math.PrintStuctures();
            Console.WriteLine("-------------------------------");

            Console.WriteLine("remove dr 2 compsc");
            HOD2_CompSc.Remove(teacher2_CompSc);
            OrgManger.PrintStuctures();
            Console.WriteLine("-------------------------------");

            Console.WriteLine("print 1 teacher");
            teacher1_CompSc.PrintStuctures();
            Console.WriteLine("-------------------------------");

        }

    }
}