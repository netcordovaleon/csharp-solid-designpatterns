namespace OCP.After
{
    public class PaymentServices
    {

        public const string CREDIT_CARD = "CreditCard";
        public const string PAYPAL = "Paypal";

        public void ProcessPayment(string type)
        {
            IPayment? payment = null;
            switch (type)
            {
                case CREDIT_CARD:
                   payment = new CreditCardPayment();
                   break;
                case PAYPAL:
                    payment = new PaypalPayment();
                    break;
            }
            payment!.Process();
        }
    }
}

