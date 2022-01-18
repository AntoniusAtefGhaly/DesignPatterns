using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    internal class DiscountCalculatorFactory
    {
        Dictionary<string, IDiscountCalculator> discounts = new Dictionary<string, IDiscountCalculator>();
        public IDiscountCalculator GetDiscountCalculator(string discountType)
        {
            IDiscountCalculator discountCalculator = null;

            if (discounts.ContainsKey(discountType))
            {
                return discounts[discountType];
            }
            else
            {
                switch (discountType)
                {
                    case "item":
                        {
                            discountCalculator = new ItemDiscountCal();
                            discounts.Add(discountType, discountCalculator);
                            break;
                        }
                    case "day":
                        {
                            discountCalculator = new DayDiscountCal();
                            discounts.Add(discountType, discountCalculator);
                            break;
                        }
                }
            }
            return discountCalculator;
        }
    }
}