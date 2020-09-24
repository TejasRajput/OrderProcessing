using OrderAppCommon.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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
