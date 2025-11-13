namespace OCP.After
{
    public class CreditCardPayment : IPayment
    {
        public void Process() => Console.WriteLine("Procesando pago con tarjeta de crédito");
    }
}
