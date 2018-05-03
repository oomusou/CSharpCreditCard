using MemberLibrary;
using OrderLibrary.Decorators;
using OrderLibrary.Interfaces;

namespace OrderLibrary.Proxies
{
    public class DiscountProxy : IPrice
    {
        private readonly MemberService _memberService = new MemberService();
        private readonly IPrice _discountDecorator;

        public DiscountProxy(IPrice decorator)
        {
            _discountDecorator = new DiscountDecorator(decorator);
        }
        
        public double GetPrice(double price)
        {
            return _memberService.IsNYearMember("Sam", 2) ? 
                   _discountDecorator.GetPrice(price) : 
                   price;
        }
    }
}