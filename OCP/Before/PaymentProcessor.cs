namespace OCP.Before
{
    public class PaymentProcessor
    {
        //Si mañana agregas “Crypto” o “ApplePay”, tienes que modificar la clase.
        public void ProcessPayment(string type)
        {
            if (type == "CreditCard") { 
                // Logica para procesar pago con tarjeta de credito
                Console.WriteLine("Procesando pago con tarjeta de crédito");
            }
            else if (type == "Paypal") { 
                // Logica para procesar pago con Paypal
                Console.WriteLine("Procesando pago con PayPal");
            }
        }
    }
}
