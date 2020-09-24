namespace OrderAppCommon.Interface
{
    public interface IPaymentRules
    {
        IPaymentResult GetProcessor(string selection);
    }
}