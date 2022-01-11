// See https://aka.ms/new-console-template for more information
namespace ImplementDesignPattern
{
    class Program
    {
        static void Main(string[] argumets)
        {
            #region 
            Counter counter1 = Counter.GetInstance();
            Counter counter2 = Counter.GetInstance();

            counter1.AddOne();
            Console.WriteLine(counter1.Count);
            Console.WriteLine(counter2.Count);

            counter1.AddOne();
            Console.WriteLine(counter1.Count);
            Console.WriteLine(counter2.Count);
            #endregion
        }
    }
}