using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    internal class ItemDiscountCal : IDiscountCalculator
    {
        public double GetDiscount(DateOnly currentDate, string itemId)
        {
            return 0.2;
        }
    }
}
