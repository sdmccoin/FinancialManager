namespace FinancialManagerNotificationService
{
    public class NotificationMessage : IMessage
    {
        public TYPE Type { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
    }
}
