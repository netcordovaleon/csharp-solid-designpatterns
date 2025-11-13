namespace Factory.After
{
    public class PushNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Conectando con servicio Push...");
            Console.WriteLine($"Enviando Push: {message}");
        }
    }
}
