using System;

namespace TemplateMethod // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Computer Sc Papers:");
            BasicEngineering basicEngineering = new ComputerScience();
            basicEngineering.Papers();

            Console.WriteLine("");

            Console.WriteLine("ElectronicsPapers:");
            basicEngineering = new Electronics();
            basicEngineering.Papers();
        }
    }
}