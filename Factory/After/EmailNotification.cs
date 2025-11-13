namespace Factory.After
{
    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Configurando servidor SMTP...");
            Console.WriteLine($"Enviando Email: {message}");
        }
    }
}
