
namespace VideoProvider
{
    public abstract class SubscriptionFactory
    {

        public static void PrintInfo(Subscription subscription)
        {
            Console.WriteLine($"is valid: {subscription.IsValid()}\nis activated: {subscription.IsActive}\n" +
                              $"date: {subscription.PurchaseDate}\nperiod: {subscription.Period}");
        }

        public abstract Subscription CreateSubscription(double price, TimeSpan period);
    }
}
