using System;
using ActivityLibrary;
using OrderLibrary.Decorators;
using OrderLibrary.Interfaces;

namespace OrderLibrary.Proxies
{
    public class HalfProxy : IPrice
    {
        private readonly ActivityService _activityService = new ActivityService();
        private readonly IPrice _halfDecorator;

        public HalfProxy(IPrice decorator)
        {
            _halfDecorator = new HalfDecorator(decorator);
        }

        public double GetPrice(double price)
        {
            return _activityService.IsInActivity(DateTime.Now) ? 
                   _halfDecorator.GetPrice(price) : 
                   price;
        }
    }
}