using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoProvider
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription(List<string> channels, TimeSpan period, double price) 
                                  : base(channels, period, price)
        {
        }
    }
}
