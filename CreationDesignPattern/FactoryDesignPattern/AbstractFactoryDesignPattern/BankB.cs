﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    internal class BankB : IBank
    {
        public void Withdrow()
        {
            Console.WriteLine("process handle by bank B");
        }
    }
}
