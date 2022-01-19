using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    internal interface IDiscountCalculator
    {
        public double GetDiscount(DateOnly currentDate,string itemId);
    }
}
