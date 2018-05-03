using OrderLibrary.Interfaces;

namespace OrderLibrary.Bank
{
    public class Taishin : IPrice
    {
        public double GetPrice(double price)
        {
            return price;
        }
    }
}