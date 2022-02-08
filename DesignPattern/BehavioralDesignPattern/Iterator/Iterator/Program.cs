using System;

namespace Iterator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arts arts = new Arts();
            IIterator artsIterator= arts.CreatIterator();
            Console.WriteLine("\n arts list");
            PrintIterator(artsIterator);
            //Console.WriteLine(artsIterator.CurrentItem());
            //Console.WriteLine(artsIterator.Next());
            //Console.WriteLine(artsIterator.Next());
            //artsIterator.First();
            //Console.WriteLine(artsIterator.CurrentItem());
            //Console.WriteLine(artsIterator.Next());
            //Console.WriteLine(artsIterator.Next());
            //Console.WriteLine(artsIterator.Next());
            //Console.WriteLine(artsIterator.IsDone());
            //Console.WriteLine(artsIterator.Next());
            //Console.WriteLine(artsIterator.IsDone());
            //Console.WriteLine(artsIterator.Next());
            //Console.WriteLine(artsIterator.IsDone());
            //Console.WriteLine(artsIterator.CurrentItem());

            // science list
            Console.WriteLine("\n science list");
            Science science = new Science();
            IIterator ScIterator = science.CreatIterator();
            PrintIterator(ScIterator);

            //Console.WriteLine(ScIterator.Next());
            //Console.WriteLine(ScIterator.Next());
            //ScIterator.First();
            //Console.WriteLine(ScIterator.Next());
            //Console.WriteLine(ScIterator.Next());
            //Console.WriteLine(ScIterator.IsDone());
            //Console.WriteLine(ScIterator.Next());
            //Console.WriteLine(ScIterator.Next());
            //Console.WriteLine(ScIterator.IsDone());

        }
        static void PrintIterator(IIterator list)
        {
            while (!list.IsDone())
            {
                Console.WriteLine(list.Next());
            }
            
        }
    }
}