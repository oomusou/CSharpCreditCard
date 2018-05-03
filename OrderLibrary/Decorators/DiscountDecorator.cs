using OrderLibrary.Interfaces;

namespace OrderLibrary.Decorators
{
    public class DiscountDecorator : DecoratorBase
    {
        private const double Discount = 0.8;
        
        public DiscountDecorator(IPrice decorator) : base(decorator)
        {
        }

        public override double GetPrice(double price)
        {
            return Discount * Decorator.GetPrice(price);
        }
    }
}