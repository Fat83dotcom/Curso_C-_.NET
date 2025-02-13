
using POOExercicies.SharedContext;

namespace POOExercicies.SubscriptionContext
{
    public class Student : Base
    {

        public Student(User user, string? name, string? email)
        {
            User = user;
            Name = name;
            Email = email;
        }
        public User? User { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public IList<Subscription> Subscriptions  { get; set; } = [];
        public bool IsPremium => Subscriptions.Any(x => x.IsActive);

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new("Premium", "O aluno já é premium."));
                return;
            }
            Subscriptions.Add(subscription);
        }
    }
}
