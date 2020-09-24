using OrderAppCommon.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderAppService
{
   public class PaymentService : IPaymentService
    {
       

        public  Task<string> PaymentProcess(string selectedItem)
        {
            return null;
        }
    }
}
