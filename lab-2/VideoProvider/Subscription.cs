using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoProvider
{
    public abstract class Subscription
    {
        public List<string> Channels {get; private set;}
        public TimeSpan Period { get; set; }
        public double Price { get; set; }
        public DateTime PurchaseDate { get; set; }   
        public bool IsActive { get; private set; }

        protected Subscription(List<string> channels, TimeSpan period, double price)
        {
            Channels = channels;
            Period = period;
            Price = price;
        }

        public virtual bool IsValid() 
        {
            if (PurchaseDate + Period < DateTime.Now)
            {
                return false;
            }
            return true;
        }

        public virtual void Activate()
        {
            if (!IsActive)
            {
                PurchaseDate = DateTime.Now;
                IsActive = true;
            }
        }
    }
}
