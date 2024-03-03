namespace Warehouse.Currency
{
    public abstract class Currency
    {
        public string Symbol { get; private set; }
        public string Name { get; private set; }

        protected Currency(string symbol, string name)
        {
            Symbol = symbol;
            Name = name;
        }
    }
}
