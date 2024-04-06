using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoProvider
{
    public class MobileApp : SubscriptionFactory
    {
        public override Subscription CreateSubscription(double price, TimeSpan period)
        {
            List<string> channels = [
                "Discovery Channel",
                "National Geographic",
                "History Channel",
                "Animal Planet",
                "PBS",
            ];

            return new EducationalSubscription(channels, period, price);
        }

    }
}
