﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Modified
{
    internal interface ICommand
    {
        void Do();
        void UnDo();
    }
}
