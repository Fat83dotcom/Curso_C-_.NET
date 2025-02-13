
namespace POOExercicies.SubscriptionContext
{
    public abstract class Subscription
    {
        public required Plan Plan { get; set; }
        public DateTime? EndDate { get; set; }

        public bool IsActive => EndDate >= DateTime.Now;

    }
}
