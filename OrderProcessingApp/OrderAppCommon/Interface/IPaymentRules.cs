using System;
using System.Collections.Generic;
using System.Text;

namespace OrderAppCommon.Interface
{
    public interface IPaymentRules
    {
        IPaymentResult GetProcessor(string selection);
    }
}
