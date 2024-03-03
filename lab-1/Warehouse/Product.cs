using Warehouse.Currency;

namespace Warehouse
{
    public static class Product
    {
        
        public static void DecreasePrice(Warehouse product,Money val)
        {
            var priceToChange = product.Prices.FirstOrDefault(price => price.Currency.Symbol == val.Currency.Symbol);
            if (priceToChange != null)
            {
                priceToChange.SetAmount(priceToChange.GetAmount() - (int)val.GetFullValue());
                priceToChange.SetCents(priceToChange.GetCents() - (int)(val.GetFullValue() % 1 * 100));
            }
        }

        public static void IncreasePrice(Warehouse product, Money val)
        {
            var priceToChange = product.Prices.FirstOrDefault(price => price.Currency.Symbol == val.Currency.Symbol);
            if (priceToChange != null)
            {
                priceToChange.SetAmount(priceToChange.GetAmount() + (int)val.GetFullValue());
                priceToChange.SetCents(priceToChange.GetCents() + (int)(val.GetFullValue() % 1 * 100));
            }
        }

        public static Money? GetPriceByCurrencySymbol(Warehouse product, string symbol)
        {
            var price = product.Prices.FirstOrDefault(p => p.Currency.Symbol == symbol);
            return price;
        }
    }
}
