
using POOExercicies.NotificationContext;

namespace POOExercicies.ContentContext
{
    public abstract class Base : Notifiable
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
