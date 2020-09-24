using System.Threading.Tasks;
using OrderAppCommon.Interface;

namespace OrderRepo
{
    public class UpgradeMembershipResult : IPaymentResult
    {
        public async Task<string> Result()
        {
            var emailResult = await CommonResult.EmailResult();
            return "Membership apply for update." + emailResult;
        }
    }
}