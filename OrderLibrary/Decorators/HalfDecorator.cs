using System;
using OrderLibrary.Interfaces;

namespace OrderLibrary.Decorators
{
    public class HalfDecorator : IPrice
    {
        private readonly IPrice _decorator;

        public HalfDecorator(IPrice decorator)
        {
            _decorator = decorator;
        }

        public double GetPrice(double price)
        {
            Console.WriteLine("加一元多一件");
            return _decorator.GetPrice(price);
        }
    }
}