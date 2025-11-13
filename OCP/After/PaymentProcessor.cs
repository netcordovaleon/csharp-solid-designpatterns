namespace OCP.After
{
    public class PaymentProcessor
    {
        public void Process(IPayment payment) => payment.Process();
    }
}
