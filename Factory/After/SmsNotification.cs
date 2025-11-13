namespace Factory.After
{
    internal class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Conectando con proveedor de SMS...");
            Console.WriteLine($"Enviando SMS: {message}");
        }
    }
}
