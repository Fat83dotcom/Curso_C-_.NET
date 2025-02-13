using POOExercicies.NotificationContext;

namespace POOExercicies.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
