namespace Factory.After
{
    public class NotificationService
    {
        public void SendNotification(string type, string message)
        {
            var notification = NotificationFactory.CreateNotification(type);
            notification.Send(message);
        }
    }
}
