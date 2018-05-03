namespace MemberLibrary
{
    public class MemberService
    {
        public bool IsMember(string account)
        {
            return account == "Sam";
        }

        public bool IsNYearMember(string account, int year)
        {
            return account == "Sam" && year == 2;
        }
    }
}