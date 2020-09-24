using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OrderAppCommon.Interface;

namespace OrderRepo
{
    public class VideoResult : IPaymentResult
    {
        public async Task<string> Result()
        {
            string message = "Learning to SKI, add free First AID videos to the packing slip.";

            return message;
        }
    }
}
