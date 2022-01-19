// See https://aka.ms/new-console-template for more information
using System.Threading;

namespace MultiThreadProblem
{
    class Program
    {
        static void Main(string[] argumets)
        {
            #region 
            Counter counter1;
            Counter counter2;
            Task.Factory.StartNew(() =>
            {
                 counter1 = Counter.GetInstance();
                counter1.AddOne();
                counter1.AddOne();
                Console.WriteLine(counter1.Count);
                Console.WriteLine(counter1.sig);

            });
            Task.Factory.StartNew(() =>
            {
                counter2 = Counter.GetInstance();
                counter2.AddOne();
                counter2.AddOne();

                Console.WriteLine(counter2.Count);
                Console.WriteLine(counter2.sig);
            });

            Console.ReadKey();  
            #endregion
        }
    }
}