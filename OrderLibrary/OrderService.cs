using System.Collections.Generic;
using OrderLibrary.Bank;
using OrderLibrary.Decorators;
using OrderLibrary.Interfaces;
using OrderLibrary.Proxies;

namespace OrderLibrary
{
    public class OrderService
    {
        private readonly Dictionary<Bank.Bank, IPrice> _decorators = new Dictionary<Bank.Bank, IPrice>();
        
        public OrderService()
        {
            _decorators.Add(Bank.Bank.ChinaTrust, new CouponProxy(new DiscountProxy(new RebateDecorator(new ChinaTrust()))));
            _decorators.Add(Bank.Bank.TaishiBank, new CouponProxy(new HalfProxy(new DiscountProxy(new Taishin()))));
            _decorators.Add(Bank.Bank.CityBank, new HalfProxy(new BonusDecorator(new RebateDecorator(new CityBank()))));
        }

        public double GetPrice(Bank.Bank bank, double price)
        {
            return _decorators[bank].GetPrice(price);
        }
    }
}