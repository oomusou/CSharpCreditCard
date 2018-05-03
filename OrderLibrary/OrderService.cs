using System;
using System.Collections.Generic;
using OrderLibrary.Bank;
using OrderLibrary.Decorators;
using OrderLibrary.Interfaces;

namespace OrderLibrary
{
    public class OrderService
    {
        private readonly Dictionary<Bank.Bank, IPrice> _decorators = new Dictionary<Bank.Bank, IPrice>();
        
        public OrderService()
        {
            _decorators.Add(Bank.Bank.ChinaTrust, new CouponDecorator(new DiscountDecorator(new RebateDecorator(new ChinaTrust()))));
            _decorators.Add(Bank.Bank.TaishiBank, new CouponDecorator(new HalfDecorator(new DiscountDecorator(new Taishin()))));
            _decorators.Add(Bank.Bank.CityBank, new HalfDecorator(new BonusDecorator(new RebateDecorator(new CityBank()))));
        }

        public double GetPrice(Bank.Bank bank, double price)
        {
            return _decorators[bank].GetPrice(price);
        }
    }
}