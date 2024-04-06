namespace VideoProvider
{
    internal class DomesticSubscription : Subscription
    {
        public DomesticSubscription(List<string> channels, TimeSpan period, int price) 
                                   : base(channels, period, price)
        {
            
        }
             
    }
}
