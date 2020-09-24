using System.Threading.Tasks;

namespace OrderAppCommon.Interface
{
    public interface IPaymentResult
    {
        Task<string> Result();
    }
}