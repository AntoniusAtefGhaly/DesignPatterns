using System;

namespace Visitor_with_Composite // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PRINCIPAL head Org Manger
            CompositeEmployee OrgManger =
                new CompositeEmployee("mr ahmed(principal) ", "Principal",30);
            //dep 1 : math 
            CompositeEmployee HOD1_math = new CompositeEmployee("mr( HOD-math) ", "math",21);

            //dep 2 : comp sc
            CompositeEmployee HOD2_CompSc = new CompositeEmployee("mr (HOD-copm.sc )", "copm.sc",18);

            IEmployee teacher1_Math = new Employee("mr (dr1 math)", "math",11);
            IEmployee teacher2_Math = new Employee("mr (dr2 math)", "math",2);

            IEmployee teacher1_CompSc = new Employee("mr (dr1 CompSc)", "CompSc",6);
            IEmployee teacher2_CompSc = new Employee("mr (dr2 CompSc)", "CompSc",4);
            IEmployee teacher3_CompSc = new Employee("mr (dr3 CompSc)", "CompSc",16);


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

            IVisitor visitor=new Visitor();
            OrgManger.accept(visitor);
        }
    }
}