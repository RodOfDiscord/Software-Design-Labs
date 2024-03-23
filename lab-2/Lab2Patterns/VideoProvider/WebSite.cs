using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoProvider
{
    public class WebSite : SubscriptionFactory
    {
        public override Subscription CreateSubscription(double price, TimeSpan period)
        {
            List<string> channels = [
                "HBO",
                "Showtime",
                "Starz",
                "Cinemax",
                "Netflix",
                "Amazon Prime Video",
            ];

            return new PremiumSubscription(channels, period, price);
        }
    }
}
