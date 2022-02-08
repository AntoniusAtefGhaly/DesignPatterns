using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Modified
{
    internal class Reciever2:IReciever
    {
        int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public Reciever2()
        {
            number = 100;
            Console.WriteLine("Receiver1 initialized with {0}", number);
            Console.WriteLine("The objects of receiver1 cannot set beyond{0}  ", number);
        }
        public void Add2WithNumber()
        {
            int presentNumber = this.Number;
            this.Number = this.Number + 2;
            Console.WriteLine("{0}+2={1}", presentNumber, this.Number);
        }

        public void OptionalTaskPostProcessing()
        {
            Console.WriteLine("Receiver1.OptionalTaskPostProcessing");
        }

        public void OptionalTaskPreProcessing()
        {
            Console.WriteLine("Receiver1.OptionalTaskPriorProcessing");
        }

        public void Remove2FromNumber()
        {
            int presentNumber = this.Number;
            //We started with number 10. We'll not decrease further.
            if (presentNumber > 100)
            {
                this.Number = this.Number - 2;
                Console.WriteLine("{0}-2={1}", presentNumber, this.Number);
            }
            else
            {
                Console.WriteLine("Nothing more to undo...");
            }
        }
    }
}
