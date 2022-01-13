using System;

namespace BuilderDesignPattern // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBuilder carBuilder = new Car("jeep");
            IBuilder motocycleBuilder = new MotorCycle("honday");
            Director director = new Director();


            //making car
            director.Construct(carBuilder);
            Product car = carBuilder.GetVicle();
            Console.WriteLine(car.show());

            //making motocycle

            director.Construct(motocycleBuilder);


            Product motor= motocycleBuilder.GetVicle();

            Console.WriteLine(motor.show());

        }
    }
}