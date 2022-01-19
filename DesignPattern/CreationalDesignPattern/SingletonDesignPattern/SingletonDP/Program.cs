// See https://aka.ms/new-console-template for more information

namespace SingletonDP
{
    class Program
    {
        static void Main(string[] argumets)
        {
            #region before using singletone
            Counter counter1 = new Counter();
            Counter counter2 = new Counter();

            counter1.addOne();
            Console.WriteLine(counter1.Count);

            counter2.addOne();
            Console.WriteLine(counter2.Count);

            counter1.addOne();
            Console.WriteLine(counter1.Count);
            counter2.addOne();
            Console.WriteLine(counter2.Count);
            #endregion

            #region 

            #endregion


        }
    }
}