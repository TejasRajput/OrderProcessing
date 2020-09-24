using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderAppCommon.Interface
{
    public interface IPaymentResult
    {
        Task<string> Result();
    }
}
