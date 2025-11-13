namespace Factory.Before
{
    public class NotificationService
    {
        public void SendNotification(string type, string message)
        {
            if (type == "email")
            {
                Console.WriteLine("Configurando servidor SMTP...");
                Console.WriteLine($"Enviando Email: {message}");
            }
            else if (type == "sms")
            {
                Console.WriteLine("Conectando con proveedor de SMS...");
                Console.WriteLine($"Enviando SMS: {message}");
            }
            else if (type == "push")
            {
                Console.WriteLine("Conectando con servicio de notificaciones push...");
                Console.WriteLine($"Enviando Push: {message}");
            }
            else
            {
                throw new Exception("Tipo de notificación no soportado");
            }
        }
    }
}
