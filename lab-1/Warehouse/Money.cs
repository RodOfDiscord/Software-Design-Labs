
namespace Warehouse
{
    public class Money : IMoney
    {
        public int Amount;
        public int Cents;
        public Currency.Currency Currency {get; set;}
        public Money(int amount, int cents, Currency.Currency currency)
        {
            Amount = amount;
            Cents = cents;
            Currency = currency;
        }

        public decimal GetFullValue() { return (decimal) (Amount + Cents / 100.0); }

        public override string ToString()
        {
            return GetFullValue().ToString();
        }

        public void SetAmount(int amount) => Amount = amount;

        public void SetCents(int cents) => Cents = cents;

        public int GetAmount() => Amount;

        public int GetCents() => Cents;

    }
}
