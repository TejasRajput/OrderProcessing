using System.Threading.Tasks;

namespace OrderAppCommon.Interface
{
    public interface IPaymentService
    {
        Task<string> PaymentProcess(string selectedItem);
    }
}