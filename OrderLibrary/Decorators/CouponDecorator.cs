using System;
using OrderLibrary.Interfaces;

namespace OrderLibrary.Decorators
{
    public class CouponDecorator : DecoratorBase
    {
        public CouponDecorator(IPrice decorator) : base(decorator)
        {
        }

        public override double GetPrice(double price)
        {
            Console.WriteLine("送100元折價券");
            return Decorator.GetPrice(price);
        }
    }
}