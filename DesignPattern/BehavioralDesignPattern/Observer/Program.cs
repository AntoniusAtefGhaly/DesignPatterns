using System;

namespace Observer // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            ObserverType1 observer1 = new ObserverType1("observ 1 ");
            ObserverType1 observer2 = new ObserverType1("observ 2 ");
            ObserverType2 observer3 = new ObserverType2("observ 3 ");
            ObserverType2 observer4 = new ObserverType2("observ 4 ");

            subject.Register(observer1);
            subject.Register(observer2);    
            subject.Register(observer3);
            subject.Register(observer4);

            subject.Flag = 50;
            subject.Unregister(observer4);
            subject.Flag = 60;
            subject.Flag = 60;



        }
    }
}