using OrderAppCommon.Interface;

namespace OrderRepo
{
    public class GetResult : IPaymentRules
    {
        public IPaymentResult GetProcessor(string selectedItem)
        {
            switch (selectedItem?.ToLower())
            {
                case "physical product":
                    return new PhysicalProductResult();

                case "book":
                    return new BookResult();

                case "membership":
                    return new MemebershipResult();

                case "videos":
                    return new VideoResult();

                case "upgrade membership":
                    return new UpgradeMembershipResult();

                default:
                    return null;
            }
        }
    }
}