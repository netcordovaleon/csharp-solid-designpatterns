namespace Factory.After
{
    public static class NotificationFactory
    {
        public static INotification CreateNotification(string type)
        {
            return type.ToLower() switch
            {
                "email" => new EmailNotification(),
                "sms" => new SmsNotification(),
                "push" => new PushNotification(),
                _ => throw new ArgumentException("Tipo de notificación no soportado")
            };
        }
    }
}
