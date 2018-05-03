using OrderLibrary.Interfaces;

namespace OrderLibrary.Decorators
{
    public class RebateDecorator : IPrice
    {
        private const int Threshold = 1000;
        private const double Minus = 100.0;
        private readonly IPrice _decorator;

        public RebateDecorator(IPrice decorator)
        {
            _decorator = decorator;
        }
        
        public double GetPrice(double price)
        {
            var newPrice = _decorator.GetPrice(price); 
            
            return newPrice >= Threshold ? 
                   newPrice - Minus : 
                   newPrice;
        }
    }
}