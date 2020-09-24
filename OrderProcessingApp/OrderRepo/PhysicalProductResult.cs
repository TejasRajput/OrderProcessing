using System.Threading.Tasks;
using OrderAppCommon.Interface;

namespace OrderRepo
{
    public class PhysicalProductResult : IPaymentResult
    {
        public async Task<string> Result()
        {
            var commission = await CommonResult.CommissionResult();

            return "Packing slip for shipping is generated." + commission;
        }
    }
}