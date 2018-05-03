using OrderLibrary.Interfaces;

namespace OrderLibrary.Decorators
{
    public class RebateDecorator : DecoratorBase
    {
        private const int Threshold = 1000;
        private const double Minus = 100.0;

        public RebateDecorator(IPrice decorator) : base(decorator)
        {
        }
        
        public override double GetPrice(double price)
        {
            var newPrice = Decorator.GetPrice(price); 
            
            return newPrice >= Threshold ? 
                   newPrice - Minus : 
                   newPrice;
        }
    }
}