using OrderLibrary.Interfaces;

namespace OrderLibrary.Bank
{
    public class CityBank : IPrice
    {
        public double GetPrice(double price)
        {
            return price;
        }
    }
}