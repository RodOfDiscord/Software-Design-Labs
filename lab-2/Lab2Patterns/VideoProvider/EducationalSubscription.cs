namespace VideoProvider
{
    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription(List<string> channels, TimeSpan period, double price)
                                   : base(channels, period, price)
        {
            
        }
    }
}
