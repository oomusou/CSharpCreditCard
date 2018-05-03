using MemberLibrary;
using OrderLibrary.Decorators;
using OrderLibrary.Interfaces;

namespace OrderLibrary.Proxies
{
    public class CouponProxy : IPrice
    {
        private readonly MemberService _memberService = new MemberService();
        private readonly IPrice _couponDecorator;

        public CouponProxy(IPrice decorator)
        {
            _couponDecorator = new CouponDecorator(decorator);
        }
        
        public double GetPrice(double price)
        {
            return _memberService.IsMember("Sam") ? 
                   _couponDecorator.GetPrice(price) : 
                   price;
        }
    }
}