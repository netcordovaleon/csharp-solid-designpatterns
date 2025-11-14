namespace OCP.Before
{
    public class PaymentProcessor
    {
        //Si mañana agregas “Crypto” o “ApplePay”, tienes que modificar la clase.
        public void ProcessPayment(string type)
        {
            if (type == "CreditCard") { 
                // Logica para procesar pago con tarjeta de credito
                /*
                 
                 Conectarte BD
                 Obtener informcion
                 Grabar
                 */
                Console.WriteLine("Procesando pago con tarjeta de crédito");
            }
            else if (type == "Paypal") { 
                // Logica para procesar pago con Paypal
                /*
                 
                 Conectarte BD
                 Obtener informcion
                 Grabar
                 */
                Console.WriteLine("Procesando pago con PayPal");
            }
        }
    }
}
