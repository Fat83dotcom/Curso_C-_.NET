
namespace POOExercicies.NotificationContext
{
    public abstract class Notifiable
    {
        public List<Notification>? Notifications { get; set; } = [];

        public void AddNotification(Notification notification)
        {
            Notifications?.Add(notification);
        }

        public void AddRangeNotifications(IEnumerable<Notification> notifications)
        {
            Notifications?.AddRange(notifications);
        }

        public bool IsInvalid => (bool)(Notifications?.Count != 0); // True se houver notificação
    }
}
