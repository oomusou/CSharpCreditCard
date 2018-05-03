using OrderLibrary.Interfaces;

namespace OrderLibrary.Decorators
{
    public class DiscountDecorator : IPrice
    {
        private const double Discount = 0.8;
        private readonly IPrice _decorator;
        
        public DiscountDecorator(IPrice decorator)
        {
            _decorator = decorator;
        }

        public double GetPrice(double price)
        {
            return Discount * _decorator.GetPrice(price);
        }
    }
}