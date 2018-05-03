using System;
using OrderLibrary.Interfaces;

namespace OrderLibrary.Decorators
{
    public class CouponDecorator : IPrice
    {
        private readonly IPrice _decorator;

        public CouponDecorator(IPrice decorator)
        {
            _decorator = decorator;
        }

        public double GetPrice(double price)
        {
            Console.WriteLine("送100元折價券");
            return _decorator.GetPrice(price);
        }
    }
}