namespace Warehouse
{
    public interface IMoney
    {
        public decimal GetFullValue();
        public void SetAmount(int amount);
        public void SetCents(int cents);
        public int GetAmount();
        public int GetCents();
    }
}
    