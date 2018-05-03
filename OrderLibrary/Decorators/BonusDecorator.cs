using System;
using OrderLibrary.Interfaces;

namespace OrderLibrary.Decorators
{
    public class BonusDecorator : DecoratorBase
    {
        public BonusDecorator(IPrice decorator) : base(decorator)
        {
        }

        public override double GetPrice(double price)
        {
            Console.WriteLine("紅利點數增加 100 點");
            return Decorator.GetPrice(price);
        }
    }
}