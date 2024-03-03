using Warehouse.Currency;

namespace Warehouse
{
    public class Warehouse
    {
        public Guid Id { get; }
        public List<Money> Prices {get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Measure { get; set; }
        public DateTime DeliveryDate { get; set; }
        public Category Category { get; set; }

        public Warehouse(List<Money>  prices, string name, double quantity, string measure, DateTime deliveryDate, Category category)
        {
            Prices = prices;
            Name = name;
            Quantity = quantity;
            Measure = measure;
            DeliveryDate = deliveryDate;
            Category = category;
        }
    }
}
