using System;
using OrderLibrary.Interfaces;

namespace OrderLibrary.Decorators
{
    public class HalfDecorator : DecoratorBase
    {
        public HalfDecorator(IPrice decorator) : base(decorator)
        {
        }

        public override double GetPrice(double price)
        {
            Console.WriteLine("加一元多一件");
            return Decorator.GetPrice(price);
        }
    }
}