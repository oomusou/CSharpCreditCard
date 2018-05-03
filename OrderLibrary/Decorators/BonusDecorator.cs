using System;
using OrderLibrary.Interfaces;

namespace OrderLibrary.Decorators
{
    public class BonusDecorator : IPrice
    {
        private readonly IPrice _decorator;

        public BonusDecorator(IPrice decorator)
        {
            _decorator = decorator;
        }

        public double GetPrice(double price)
        {
            Console.WriteLine("紅利點數增加 100 點");
            return _decorator.GetPrice(price);
        }
    }
}