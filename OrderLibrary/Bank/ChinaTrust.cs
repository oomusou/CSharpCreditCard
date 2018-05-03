using OrderLibrary.Interfaces;

namespace OrderLibrary.Bank
{
    public class ChinaTrust : IPrice
    {
        public double GetPrice(double price)
        {
            return price;
        }
    }
}