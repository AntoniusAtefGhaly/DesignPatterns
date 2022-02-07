using System;

namespace Strategy // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            Console.WriteLine("***Strategy Pattern Demo***\n");
            IChoice ic = null;
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("\nEnter ur choice(1 or 2)");
                string c = Console.ReadLine();
                if (c.Equals("1"))
                {
                    ic = new FirstChoice();
                }
                else
                {
                    ic = new SecondChoice();
                }
                context.SetChoice(ic);
                context.ShowChoice();
            }
            Console.ReadKey();
        }
    }
}