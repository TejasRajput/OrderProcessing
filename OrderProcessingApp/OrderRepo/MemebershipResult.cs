using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OrderAppCommon.Interface;

namespace OrderRepo
{
    public class MemebershipResult : IPaymentResult
    {
        public async Task<string> Result()
        {
            var emailResult = await CommonResult.EmailResult();
            return "Membership Activated." + emailResult;
        }
    }
}
