namespace OCP.After
{
    public class PaypalPayment : IPayment
    {
        //Puedes agregar nuevos tipos de pago sin tocar PaymentProcessor.
        public void Process() => Console.WriteLine("Procesando pago con PayPal");
    }
}
