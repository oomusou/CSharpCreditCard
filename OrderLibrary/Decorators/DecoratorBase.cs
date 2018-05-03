using OrderLibrary.Interfaces;

namespace OrderLibrary.Decorators
{
    public abstract class DecoratorBase : IPrice
    {
        protected readonly IPrice Decorator;

        protected DecoratorBase(IPrice decorator)
        {
            Decorator = decorator;
        }
        
        public abstract double GetPrice(double price);
    }
}