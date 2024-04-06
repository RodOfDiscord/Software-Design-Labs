namespace VideoProvider
{
    public class ManagerCall : SubscriptionFactory
    {
        public override Subscription CreateSubscription(double price, TimeSpan period)
        {
            List<string> channels = [
                "Перший національний",
                "ICTV",
                "1+1",
                "Новий канал",
                "СТБ",
                "Україна",
                "ТЕТ",
                "К1",
                "Інтер",
            ];

            return new DomesticSubscription(channels, TimeSpan.FromDays(31), 300);
        }
    }
}
