using System.Threading.Tasks;

namespace OrderRepo
{
    public static class CommonResult
    {
        public static async Task<string> CommissionResult()
        {
            return "Commission Payment of the agent";
        }

        public static async Task<string> EmailResult()
        {
            return "Email has been sent to owner about activation or upgrade.";
        }
    }
}