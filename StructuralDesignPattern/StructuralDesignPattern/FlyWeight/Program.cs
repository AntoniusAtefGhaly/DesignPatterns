using System;

namespace FlyWeight 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiscountCalculatorFactory discountCalculatorFactory = new DiscountCalculatorFactory();
            IDiscountCalculator discountCalculator = discountCalculatorFactory.GetDiscountCalculator("day");
            Console.WriteLine("day discount");
            Console.WriteLine(discountCalculator.GetDiscount(DateOnly.FromDateTime(DateTime.Now),"").ToString());

            discountCalculator = discountCalculatorFactory.GetDiscountCalculator("item");
            Console.WriteLine("product discount");
            Console.WriteLine(discountCalculator.GetDiscount(DateOnly.FromDateTime(DateTime.Now), "").ToString());

            discountCalculator = discountCalculatorFactory.GetDiscountCalculator("day");
            Console.WriteLine("day discount");
            Console.WriteLine(discountCalculator.GetDiscount(DateOnly.FromDateTime(DateTime.Now), "").ToString());

            discountCalculator = discountCalculatorFactory.GetDiscountCalculator("item");
            Console.WriteLine("product discount");
            Console.WriteLine(discountCalculator.GetDiscount(DateOnly.FromDateTime(DateTime.Now), "").ToString());

        }
    }
}