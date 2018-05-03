using OrderLibrary.Interfaces;

namespace OrderLibrary.Bank
{
    public abstract class BankBase : IPrice
    {
        public double GetPrice(double price)
        {
            return price;
        }
    }
}