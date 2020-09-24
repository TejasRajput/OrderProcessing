using System.Threading.Tasks;
using OrderAppCommon.Interface;

namespace OrderAppService
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRules _paymentRules;

        public PaymentService(IPaymentRules paymentRules)
        {
            _paymentRules = paymentRules;
        }


        public async Task<string> PaymentProcess(string selectedItem)
        {
            return await _paymentRules.GetProcessor(selectedItem)?.Result();
        }
    }
}