using System.Threading.Tasks;
using OrderAppCommon.Interface;

namespace OrderRepo
{
    public class BookResult : IPaymentResult
    {
        public async Task<string> Result()
        {
            var commission = await CommonResult.CommissionResult();
            return "Duplicate Sleep Created for the royalty department." + commission;
        }
    }
}